



import sys
import pprint

sys.path.append('c:/users/koyanagikazuya/anaconda3/lib/site-packages')
sys.path.append('c:/users/koyanagikazuya/anaconda3')

pprint.pprint(sys.path)

import numpy
sklearn

# ライブラリの読み込み
from sklearn.ensemble import RandomForestClassifier
from sklearn import datasets
from sklearn.model_selection import train_test_split

# irisデータの読み込み
iris = datasets.load_iris()

# 特徴量とターゲットの取得
data       = iris['data']
target     = iris['target']

#学習データをテストデータを分割
train_data,test_data,train_target,test_target = train_test_split(data,target,test_size=0.5)

#モデル学習
model = RandomForestClassifier(n_estimators=100)
model.fit(train_data, train_target)

# 正解率を表示
model.score(test_data, test_target)