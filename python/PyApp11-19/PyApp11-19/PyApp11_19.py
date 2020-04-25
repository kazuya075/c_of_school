
import wikipediaapi
import csv
import pprint

import numpy as np
import matplotlib.pyplot as plt
import matplotlib



#matplotlib.use('TkAgg')


print(matplotlib.matplotlib_fname())

import sys
import json
import urllib
sys.path.append('c:/users/koyanagikazuya/anaconda3/lib/site-packages')
import math
import requests
import json

import urllib
import wikipedia

from matplotlib import pyplot


wikipedia.set_lang("ja")#使用言語設定

"""


"""

result_edit=[]
result_ran_edit=[]
result_view=[]
result_ran_view=[]


test = wikipedia.search("中立的観点に議論ある項目",500)
wiki_random = wikipedia.random(500)#ランダムに記事を取得


for i in range(10):#閲覧回数の日程を編集に持ってくる
    sum_views=0
    pagetitle=urllib.parse.quote(wiki_random[i])
    print(wiki_random[i])

    t1='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article/ja.wikipedia/all-access/all-agents/{x_article}/daily/{ymd_from}/{ymd_to}'

    ymd_from='20000101' # 日付開始
    ymd_to=  '20220505'   # 日付終わり
    x_article = pagetitle
    
    

    req = requests.get(t1.format(ymd_from=ymd_from, x_article=x_article, ymd_to=ymd_to))#req.text

    list2=[]#リスト内に期間が入っている

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
    

  
print("ランダム記事:閲覧数",result_ran_view)
print("ランダム記事:編集数",result_ran_edit)


with open(r'c:/Users/KoyanagiKazuya/Desktop/11-22/sample_writer_row.csv', 'w', newline="") as f:
    writer = csv.writer(f)

    writer.writerow(['',"edit","view","NofItem","TexNum","isbn","url"])

    for item in range(len(result_ran_edit)):
       print(item)
       writer.writerow(['',result_ran_view[item],result_ran_edit[item]])

with open(r'c:/Users/KoyanagiKazuya/Desktop/11-22/sample_writer_row.csv') as f:
    print(f.read())








for i in range(10):#閲覧回数の日程を編集に持ってくる
    sum_views=0
    pagetitle=urllib.parse.quote(test[i])
    print(test[i])

    t1='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article/ja.wikipedia/all-access/all-agents/{x_article}/daily/{ymd_from}/{ymd_to}'

    ymd_from='20000101' # 日付開始
    ymd_to=  '20220505'   # 日付終わり
    x_article = pagetitle
    
    

    req = requests.get(t1.format(ymd_from=ymd_from, x_article=x_article, ymd_to=ymd_to))#req.text

    list2=[]#日にちを一日ずつ入れる

    for one in json.loads(req.text)['items']:#すべての日にちの閲覧数を総和する
        list2.append(one['timestamp'])
        sum_views +=one['views']

    print("閲覧数",sum_views)
    result_view.append(sum_views)
    
    a=int(list2[-1])-int(list2[1])
    ro=math.floor(a/1000000)
    
    #print(math.floor(a/1000000))

    t2='https://wikimedia.org/api/rest_v1/metrics/edits/per-page/ja.wikipedia/{pagetitle}/all-editor-types/monthly/{ymd_from1}/{ymd_to1}'




    sum1=0
    sum2=1000000
    sum_edit=0
    for i in range(ro):
        

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
    result_edit.append(sum_edit)
    
print("問題のある記事:閲覧数",result_view)
print("問題のある記事:編集数",result_edit)   
 







wiki = wikipediaapi.Wikipedia('ja')
mutcd = wiki.page('スローロリス')

tablelen="\n".join([s.title for s in mutcd.sections])

tablelistlen=tablelen.split()
print(len(tablelistlen))

#CSVファイル内に書き込み
with open(r'c:/Users/KoyanagiKazuya/Desktop/11-22/sample_writer_row2.csv', 'w', newline="") as f:
    writer = csv.writer(f)

    writer.writerow(['',"edit","view","NofItem","TexNum","isbn","url"])

    for item in range(len(result_view)):
       print(item)
       writer.writerow(['',result_view[item],result_edit[item]])

with open(r'c:/Users/KoyanagiKazuya/Desktop/11-22/sample_writer_row2.csv') as f:
    print(f.read())








pyplot.scatter(result_ran_edit, result_ran_view,   c='b', label = 'test_ran') 
pyplot.scatter(result_edit, result_view,   c='r', label = 'test_pro')

pyplot.legend()
pyplot.title("test_datas")
pyplot.show()
