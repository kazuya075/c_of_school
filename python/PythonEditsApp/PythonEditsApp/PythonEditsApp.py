
import requests
import json
import urllib
import wikipedia
wikipedia.set_lang("ja")#ここが抜けていた

t1='https://wikimedia.org/api/rest_v1/metrics/edits/per-page/{x_lang}.wikipedia/{pagetitle}/all-editor-types/monthly/{ymd_from}/{ymd_to}'

result_edit=[0] * 10
result_ran_edit=[0] * 10

test = wikipedia.search("中立的観点に議論ある項目",10)
#print(test)
wiki_random=wikipedia.random(10)
#print(wiki_random)

#リスト利用時のコード
#print(len(test))


ymd_from='2005050100' # 日付開始
ymd_to=  '2006050100'   # 日付終わり
#x_article = urllib.parse.quote('中国') # 
x_lang = 'ja' # 日本語の指定
x_type='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article'

for i in range(10):

    pagetitle=urllib.parse.quote(test[i])#'Albert Einstein'


    sum_edit=0
    req = requests.get(t1.format(ymd_from=ymd_from, x_lang=x_lang, x_type=x_type,  ymd_to=ymd_to, pagetitle=pagetitle))#req.text
    for one in json.loads(req.text)['items']:
        for o in one['results']:
            sum_edit+=o['edits']
        #sum_edit.append(o['edits'])
    result_edit[i]=sum_edit  
    print(sum_edit) 
        
print(result_edit)  






for i in range(10):

    pagetitle=urllib.parse.quote(wiki_random[i])#'Albert Einstein'


    sum_edit=0
    req = requests.get(t1.format(ymd_from=ymd_from, x_lang=x_lang, x_type=x_type,  ymd_to=ymd_to, pagetitle=pagetitle))#req.text
    for one in json.loads(req.text)['items']:
        for o in one['results']:
            sum_edit+=o['edits']
        #sum_edit.append(o['edits'])
    result_ran_edit[i]=sum_edit  
    print(sum_edit) 
        
print(result_ran_edit)  