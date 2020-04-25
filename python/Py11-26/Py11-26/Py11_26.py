
import wikipediaapi
import csv
import pprint

import numpy as np
import matplotlib.pyplot as plt
import matplotlib
matplotlib.use('TkAgg')
#print(matplotlib.matplotlib_fname())
import sys
import json
import urllib
sys.path.append('c:/users/koyanagikazuya/anaconda3/lib/site-packages')
import math
import requests
import re

from matplotlib import pyplot
import wikipedia
import json
import urllib
wikipedia.set_lang("ja")




result_nofitem=[]
result_ran_nofitem=[]

result_texnum=[]
result_ran_texnum=[]

result_isbns=[]
result_ran_isbns=[]

result_urls=[]
result_ran_urls=[]

result_edit=[]
result_ran_edit=[]

result_view=[]
result_ran_view=[]




wikipedia.set_lang("ja")
#wikipedia.search("中立的観点に議論ある項目",10)


ny2 = wikipedia.page("Wikipedia:良質な記事")
re_ny=ny2.links

"""
#new_text = re.findall(r'<(.*)>', re_ny2)
print(len(re_ny)) 
print(re_ny)

"""


test = wikipedia.search("中立的観点に議論ある項目",500)
#wiki_random = wikipedia.random(500)#ランダムに記事を取得
wiki_random =ny2.links


num=100
for i in range(num):#閲覧回数の日程を編集に持ってくる
    sum_views=0
    pagetitle=urllib.parse.quote(wiki_random[i])
    print(wiki_random[i])


    #項目数

    wiki = wikipediaapi.Wikipedia('ja')
    mutcd = wiki.page(wiki_random[i])

    tablelen="\n".join([s.title for s in mutcd.sections])

    nofitem=tablelen.split()

    print(nofitem)
    print("項目数",len(nofitem))
    result_ran_nofitem.append(len(nofitem))

    try:
        #本文量
        texnum = wikipedia.page(wiki_random[i])
        texnum2 = wikipedia.page(wiki_random[i])

        #  texnum.content
        print("本文量",len(texnum.content))
        result_ran_texnum.append(len(texnum.content))


        #isbn
        re_ny2=texnum.html()

        isbns = re.findall(r'isbn=\d+', re_ny2)
        #print(isbns)
        print("isbn",len(isbns) )
        result_ran_isbns.append(len(isbns))


        #url
        urls=texnum2.references
        #print(urls)
        print("url",len(urls))
        result_ran_urls.append(len(urls))

    except KeyError:
        print ("リンクのない参照がある.")
        result_ran_urls.append(0)

    except wikipedia.exceptions.DisambiguationError  as e:
        print('エラー、wikiの結果が上手く返ってきませんでした。')
        result_ran_texnum.append(0)
        result_ran_isbns.append(0)
        result_ran_urls.append(0)
    except wikipedia.exceptions.PageError as e:
        print(e)


    t1='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article/ja.wikipedia/all-access/all-agents/{x_article}/daily/{ymd_from}/{ymd_to}'

    ymd_from='20000101' # 日付開始
    ymd_to=  '20220505'   # 日付終わり
    x_article = pagetitle
    
    

    req = requests.get(t1.format(ymd_from=ymd_from, x_article=x_article, ymd_to=ymd_to))#req.text

    list2=[]#リスト内に期間が入っている
    try:
        for one in json.loads(req.text)['items']:
           list2.append(one['timestamp'])
           sum_views +=one['views']
             #print(sum_views)
    
        print("閲覧数",sum_views)
        result_ran_view.append(sum_views)
    
        a=int(list2[-1])-int(list2[1])#リスト内の期間の初めと終わりからループ数を出す
        ro=math.floor(a/1000000)#切り捨て
    
    #print(math.floor(a/1000000))






        t2='https://wikimedia.org/api/rest_v1/metrics/edits/per-page/ja.wikipedia/{pagetitle}/all-editor-types/monthly/{ymd_from1}/{ymd_to1}'


        sum1=0
        sum2=1000000
        sum_edit=0
        for i in range(ro):#繰り返し数
        

            ymd_from1=int(list2[0])+sum1 # 日付開始
            ymd_to1  =ymd_from1+sum2
    
            #print(ymd_from1)
             #print(ymd_to1)
        
            pagetitle=pagetitle

            req1 = requests.get(t2.format(ymd_from1=ymd_from1, ymd_to1=ymd_to1, pagetitle=pagetitle))#req.text
            for one in json.loads(req1.text)['items']:
                for o in one['results']:
                    #print(o['edits'])
                    sum_edit+=o['edits']
                
                 #
                    #print(sum_edit)   

            sum1+=1000000 
        print("編集数",sum_edit)    
        result_ran_edit.append(sum_edit)
    except KeyError:
        print ("KeyError: 'items'.")
        result_ran_view.append(0)
        result_ran_edit.append(0)
  
print("ランダム記事:閲覧数",result_ran_view)
print("ランダム記事:編集数",result_ran_edit)


with open(r'c:/Users/KoyanagiKazuya/Desktop/11-29-1/sample_writer_row7.csv', 'w', newline="") as f:
    writer = csv.writer(f)

    writer.writerow(['point',"view","edit","NofItem","TexNum","isbn","url"])

    for item in range(num):
       print(item)
       writer.writerow(['1',result_ran_view[item] ,result_ran_edit[item] ,result_ran_nofitem[item] ,result_ran_texnum[item],result_ran_isbns[item],result_ran_urls[item]   ])

with open(r'c:/Users/KoyanagiKazuya/Desktop/11-29-1/sample_writer_row7.csv') as f:
    print(f.read())




