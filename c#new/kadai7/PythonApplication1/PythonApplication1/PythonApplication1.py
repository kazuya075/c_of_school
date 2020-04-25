
data = open("name.txt", "r")

# 行ごとにすべて読み込んでリストデータにする
lines = data.readlines()

# 一行ずつ表示する
for line in lines:
  print(line)

# ファイルをクローズする
data.close()