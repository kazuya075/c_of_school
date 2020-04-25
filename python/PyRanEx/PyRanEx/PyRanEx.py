
import pandas as pd
#df = pd.read_csv('c:/Users/KoyanagiKazuya/Desktop/12-6/merge.csv')
df = pd.read_csv('c:/Users/Kazuy/Desktop/研究室/12-20/merge.csv')

#df = pd.read_csv('c:/Users/Koyanagi/Desktop/11-29-1/merge.csv')

import matplotlib.pyplot as plt
import seaborn as sns
#%matplotlib inline
#sns.countplot('Sex',hue='Survived',data=df)

from sklearn.model_selection import train_test_split


train_X = df.drop('point', axis=1)
train_y = df.point
(train_X, test_X ,train_y, test_y) = train_test_split(train_X, train_y, test_size = 0.3, random_state =1500)
###



from sklearn.metrics import (roc_curve, auc, accuracy_score)
from sklearn.tree import DecisionTreeClassifier



from sklearn.ensemble import RandomForestClassifier
clf = RandomForestClassifier(random_state=0)
###

clf = clf.fit(train_X, train_y)
pred = clf.predict(test_X)
fpr, tpr, thresholds = roc_curve(test_y, pred, pos_label=1)
auc(fpr, tpr)
accuracy_score(pred, test_y)