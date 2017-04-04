#!/bin/bash
FOLDERS=$(ls . | grep -Ev 'xml|py|sh')
NUMBER_OF_FOLDERS=$(echo "$FOLDERS" | wc -l)
LOADING_BAR=".................."
CURRENT_FOLDER_NUMBER=0
for FOLDER in $FOLDERS
do
    z=$((100*CURRENT_FOLDER_NUMBER/NUMBER_OF_FOLDERS))
    printf "Converting gifs $LOADING_BAR $z %% complete\r"
    LOADING_BAR="${LOADING_BAR:0:3*CURRENT_FOLDER_NUMBER}###${LOADING_BAR:3*CURRENT_FOLDER_NUMBER+3}"
    CURRENT_FOLDER_NUMBER=$((CURRENT_FOLDER_NUMBER+1))
    FILES=$(ls $FOLDER | grep .gif)
    for FILE in $FILES
    do
        convert -delay 4x100 $FOLDER/$FILE $FOLDER/$FILE
        convert $FOLDER/$FILE \( +clone -set delay 150x100 \) +swap +delete $FOLDER/$FILE
    done
done
printf "Converting gifs $LOADING_BAR 100 %% complete!\n"
