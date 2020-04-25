
#import wikipedia
#ny = wikipedia.page("New York")
#wikipedia.set_lang("ja")
#wikipedia.search("中立的観点に議論ある項目",10)
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


#with open('Users/fmv/Desktop/11-22/sample_writer_row.csv', 'w') as f:
with open(r'c:/Users/fmv/Desktop/11-22/sample_writer_row.csv', 'w', newline="") as f:
    writer = csv.writer(f)
    writer.writerow([0, 1, 2])
    writer.writerow([0,0,len(tablelistlen)])

with open(r'c:/Users/fmv/Desktop/11-22/sample_writer_row.csv') as f:
    print(f.read())