
#ny = wikipedia.page("Wikipedia:良質な記事")
#ny = wikipedia.page("砂鉄")
#ny.sections

import wikipediaapi
import csv
import pprint


wiki = wikipediaapi.Wikipedia('ja')
mutcd = wiki.page('スローロリス')
#print("\n".join([s.title for s in mutcd.sections]))

tablelen="\n".join([s.title for s in mutcd.sections])

tablelistlen=tablelen.split()
#print(tablelistlen)
print(len(tablelistlen))



a=[1, 2, 3]
b=[4, 5, 6]

#with open('Users/fmv/Desktop/11-22/sample_writer_row.csv', 'w') as f:
with open(r'c:/Users/KoyanagiKazuya/Desktop/11-22/sample_writer_row.csv', 'w', newline="") as f:
    writer = csv.writer(f)
    """
    writer.writerow([0, 1, 2])
    writer.writerow([0,0,len(tablelistlen)])
    """
    for item in range(len(a)):
        print(item)
        writer.writerow([a[item],b[item]])
        




with open(r'c:/Users/KoyanagiKazuya/Desktop/11-22/sample_writer_row.csv') as f:
    print(f.read())