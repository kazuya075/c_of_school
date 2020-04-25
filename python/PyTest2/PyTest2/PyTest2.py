import wikipediaapi
import csv
import pprint


wiki = wikipediaapi.Wikipedia('ja')
mutcd = wiki.page('スローロリス')

tablelen="\n".join([s.title for s in mutcd.sections])

tablelistlen=tablelen.split()
print(len(tablelistlen))




with open(r'c:/Users/fmv/Desktop/11-22/sample_writer_row.csv', 'w', newline="") as f:
    writer = csv.writer(f)
    writer.writerow([0, 1, 2])
    writer.writerow([0,0,len(tablelistlen)])

with open(r'c:/Users/fmv/Desktop/11-22/sample_writer_row.csv') as f:
    print(f.read())
