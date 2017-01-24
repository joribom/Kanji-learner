# coding=utf-8
import urllib
import os
import urllib2
import re

xmlFiles = [f[:-4] for f in os.listdir('.') if f[-9:] == "Kanji.xml"]  # reads the number of files in the folder to start downloading at the next comic
print xmlFiles

def download_gif(url, comicName):
    """download a comic in the form of
       url = http://www.example.com
       comicName = '00000000.jpg'
    """
    image = urllib.URLopener()
    image.retrieve(url, comicName)  # download comicName at URL

def get_gif_url(webpage_url):
    response = urllib2.urlopen(webpage_url)
    html = response.read()
    for line in html.split("\n"):
        if 'src=/ocjs/kanjidic.nsf/' in line:
            match = re.search(r'src=(.*?).gif', line)
            if match: 
                return "http://www.yamasa.org" + match.group(1) + "_ani.gif"

def download_kanji_gif(kanji, directory):
    if not os.path.exists(xmlFile + "/" + kanji + ".gif"):
        url = "http://www.yamasa.org/ocjs/kanjidic.nsf/SortedByKanji2THEnglish/" + urllib.quote(kanji) + "?OpenDocument"
        gif_url = get_gif_url(url)
        download_gif(gif_url, directory + "/" + kanji + ".gif")
        print "'" + directory + "/" + kanji + ".gif' has been created."

nogif = []

for xmlFile in xmlFiles:
    if not os.path.exists(xmlFile):
        os.makedirs(xmlFile)
    f = open(xmlFile + ".xml")
    for line in f:
        match = re.search(r"<Kanji>(.*)</Kanji>", line)
        if match:
            try:
                download_kanji_gif(match.group(1), xmlFile)
            except:
                nogif.append(match.group(1))
    f.close()

for kanji in nogif:
    print "No gif found for '" + kanji + "'"