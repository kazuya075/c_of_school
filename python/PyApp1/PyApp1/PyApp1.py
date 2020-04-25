
import sys
import json
import urllib


sys.path.append('c:/users/koyanagikazuya/anaconda3/lib/site-packages')
sys.path.append('c:/users/koyanagikazuya/anaconda3/lib/site-packages/matplotlib')

from matplotlib import pyplot as plt
import requests
import json
import urllib
import wikipedia




wikipedia.set_lang("ja")


result_edit=[]
result_ran_edit=[]
result_view=[]
result_ran_view=[]


test = wikipedia.search("中立的観点に議論ある項目",100)
wiki_random = wikipedia.random(100)


for i in range(5):#閲覧回数の日程を編集に持ってくる
    sum_views=0
    pagetitle=urllib.parse.quote(wiki_random[i])
    print(wiki_random[i])

    t1='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article/ja.wikipedia/all-access/all-agents/{x_article}/daily/{ymd_from}/{ymd_to}'

    ymd_from='20000101' # 日付開始
    ymd_to=  '20220505'   # 日付終わり
    x_article = pagetitle
    

    req = requests.get(t1.format(ymd_from=ymd_from, x_article=x_article, ymd_to=ymd_to))#req.text

    list2=[]

    for one in json.loads(req.text)['items']:
        list2.append(one['timestamp'])
        sum_views +=one['views']
    
    print("閲覧数",sum_views)
    result_ran_view.append(sum_views)



    t2='https://wikimedia.org/api/rest_v1/metrics/edits/per-page/ja.wikipedia/{pagetitle}/all-editor-types/monthly/{ymd_from1}/{ymd_to1}'


    sum1=0
    sum2=1000000
    sum_edit=0
    for i in range(4):
        

        ymd_from1=int(list2[0])+sum1 # 日付開始
        ymd_to1  =ymd_from1+sum2
    

        pagetitle=pagetitle

        req1 = requests.get(t2.format(ymd_from1=ymd_from1, ymd_to1=ymd_to1, pagetitle=pagetitle))#req.text
        for one in json.loads(req1.text)['items']:
            for o in one['results']:
                sum_edit+=o['edits']


        sum1+=1000000 
    print("編集数",sum_edit)    
    result_ran_edit.append(sum_edit)
    

print("ランダム記事:編集数",result_ran_edit)  
print("ランダム記事:閲覧数",result_ran_view)



for i in range(5):#閲覧回数の日程を編集に持ってくる
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


    t2='https://wikimedia.org/api/rest_v1/metrics/edits/per-page/ja.wikipedia/{pagetitle}/all-editor-types/monthly/{ymd_from1}/{ymd_to1}'


    sum1=0
    sum2=1000000
    sum_edit=0
    for i in range(4):
        

        ymd_from1=int(list2[0])+sum1 # 日付開始
        ymd_to1  =ymd_from1+sum2
    
       
        pagetitle=pagetitle

        req1 = requests.get(t2.format(ymd_from1=ymd_from1, ymd_to1=ymd_to1, pagetitle=pagetitle))#req.text
        for one in json.loads(req1.text)['items']:
            for o in one['results']:

                sum_edit+=o['edits']
   
        sum1+=1000000 
    print("編集数",sum_edit)     
    result_edit.append(sum_edit)
    
print("問題のある記事:閲覧数",result_view)
print("問題のある記事:編集数",result_edit)   
 

pyplot.scatter(result_ran_edit, result_ran_view,   c='b', label = 'test_ran') 
pyplot.scatter(result_edit, result_view,   c='r', label = 'test_pro')

pyplot.legend()
pyplot.title("test_datas")
pyplot.show()