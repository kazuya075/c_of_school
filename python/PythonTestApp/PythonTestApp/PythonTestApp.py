
import wikipedia
wikipedia.set_lang("ja")


ny = wikipedia.search("中立的観点に議論ある項目",1000)
print(len(ny))

import requests
import json
import urllib

t1='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article/{x_lang}.wikipedia/all-access/all-agents/{x_article}/daily/{ymd_from}/{ymd_to}'


# 英語 Shinzō_Abe
#x_article='Shinz%C5%8D_Abe'
#x_lang = 'en' # 英語の指定


ymd_from='2017050100' # 日付開始
ymd_to='2017050200'   # 日付終わり
x_article = urllib.parse.quote('中国') # 
x_lang = 'ja' # 日本語の指定
x_type='https://wikimedia.org/api/rest_v1/metrics/pageviews/per-article'


req = requests.get(t1.format(ymd_from=ymd_from, x_lang=x_lang, x_type=x_type, x_article=x_article, ymd_to=ymd_to))#req.text
for one in json.loads(req.text)['items']:
    print(one['timestamp'] + "\t" + str(one['views']) )
