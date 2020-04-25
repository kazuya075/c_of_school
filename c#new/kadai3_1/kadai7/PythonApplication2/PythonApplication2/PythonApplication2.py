
i=0
keys =[]
values=[]
values2=[]
val=[]


f = open("name.txt", "r")
lines2 = f.readlines() # 1行毎にファイル終端まで全て読む(改行文字も含まれる)
num_lines = sum(1 for line in open("name.txt", "r"))#テキストデータの行数
#print(num_lines)

for line in lines2:
	if i%3==0:
		values.append(line.strip())
	if i%3==1:
		values2.append(line.strip())
	if i%3==2:
	    keys.append(line.strip())
	i+=1


#val[0]=values[0]+values2[0]
#"""
n=int(num_lines/3)
for num in range(n):
    val.append(values[num]+" "+values2[num])
	

#"""
#print(val[0])
#print(values3)
#str=values[1]+values2[1]
#print(str)
print(keys,":keys")
print(val,"val")
print(values+values2,"values")

dic = dict(zip(keys, val)) 
val = dic["1163033075"]
print(val)





f.close()