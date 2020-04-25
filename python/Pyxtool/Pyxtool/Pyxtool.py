
import requests
import json
import urllib
#import xtools
from urllib.request import Request, urlopen
from urllib.parse import urlencode
from urllib.error import URLError, HTTPError
import json
 
def set_params(page_title):
    params = {
        'action': 'query',
        'prop': 'revisions',
        'rvprop': 'content',
        'titles': page_title,
        'formatversion': 2,
        'format': 'json',
    }
 
    return params
 
def main():
    request_url = 'https://ja.wikipedia.org/w/api.php?' + urlencode(set_params('ウィキペディア'))
 
    req = Request(request_url)
 
    try:
        with urlopen(req) as res:
            res_json = res.read()
    except HTTPError as e:
        print('HTTPError: {}'.format(e.reason))
    except URLError as e:
        print('URLError: {}'.format(e.reason))
    else:
        wiki = json.loads(res_json.decode('utf-8'))
        #print(wiki['query']['pages'][0]['revisions'][0]['content'])
 
if __name__ == '__main__':
    main()
    
#t1='https://xtools.wmflabs.org/api/page/top_editors/en.wikipedia/Albert_Einstein/2000-01-01/2020-01-01'
t1='https://xtools.wmflabs.org/api/page/articleinfo/en.wikipedia.org/Albert_Einstein'


req = requests.get(t1)#req.text

result = req.text

#editors
print(json.loads(req.text)['editors'])
print(result)