FOLDERS=$(ls . | grep -Ev 'xml|py|sh')
for FOLDER in $FOLDERS
do
    FILES=$(ls $FOLDER | grep .gif)
    for FILE in $FILES
    do
        $(convert -delay 4x100 $FOLDER/$FILE $FOLDER/$FILE)
    done
done