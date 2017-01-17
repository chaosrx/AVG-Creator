# AVG Creator
AVG Creator 是一款開放、簡單、易用的冒險故事遊戲引擎，只要學會簡易的腳本就能建立一款自己的 AVG 遊戲。
# 遊戲範例
如果你好奇 AVG Creator 做出來的遊戲是什麼樣的，我們提供了一組[官方範例](https://github.com/gentle-shao/AVG-Creator/blob/master/sample.zip "遊戲範例")。
# 注意事項
這款軟體目前仍處於開發狀態，腳本、函數及功能還有可能變動，在穩定版本發布之前，不建議作為正式遊戲開發用途。
#腳本釋例
```
//AVG Creator Sample Script
//圖片素材來自星宝転生ジュエルセイバー
//JewelSaviorFREE
//http://www.jewel-s.jp/
//背景音樂來自Atelier Nonta
//音效來自小森 平（http://taira-komori.jpn.org/freesoundtw.html）
//
//
//腳本最前面加上雙斜槓，AVG Creator 就不會將其解讀為指令
//所有資源文件（圖片、音樂）都應存放於 assets 資料夾中
//遊戲資訊：[info]遊戲名稱,作者,備註,AVG Creator版本,遊戲版本
//載入背景：[bgim]要載入的背景圖片檔名（應放在 assets 資料夾下）
//顯示對話：[dial]角色名稱,對話內容（不可包含小寫逗號）,大頭貼圖片檔名
//載入角色：[char]1/2（最多可同時顯示兩個角色）,圖片檔名,X座標,Y座標,圖片長度,圖片寬度
//場景結束：[next]等待玩家再次點擊滑鼠，載入下一個場景（此函數沒有提供參數，直接調用即可）
//清除角色：[crcl]1/2/3（清除角色1或角色2，3為同時清除兩者）
//清除對話：[dlcl]清除對話框內容及大頭貼（此函數沒有提供參數，直接調用即可）
//背景音樂：[plmc]背景音樂檔名（支援mp3、wav格式）,音量（0~100）
//停止播放：[stmc]停止播放目前背景音樂（此函數沒有提供參數，直接調用即可）
//播放音效：[plau]音效檔名（支援mp3、wav格式）,音量（0~100） 音效播放一次即停止，故不提供函數來停止播放
//全屏模式：[full]隱藏對話框（此函數沒有提供參數，直接調用即可）
//退出全屏：[show]顯示對話框（此函數沒有提供參數，直接調用即可）
//跳至某行：[goto]從指定的行數繼續執行
//給予選項：[sect]選項1,選項2,選項3,選項4（如果選項不足四個，需填入null）
//選項結果：[answ]選擇選項1後要跳至哪一行,選擇選項2後要跳至哪一行,選擇選項3後要跳至哪一行,選擇選項4後要跳至哪一行（如果選項不足四個，需填入null）
//
//
[info]Development Sample,Gentle_Shao,這款遊戲是專門針對 AVG Creator 開發的範例遊戲，圖片素材來自JewelSaviorFREE（http://www.jewel-s.jp/），其餘訊息請至腳本中查看,1000,v1.0.0.0
[full]
[plmc]music\village1_d.mid,50
[bgim]background\start.jpg
[next]
[show]
[bgim]background\5_town_a.jpg
[plmc]music\town1_d.mid,70
[char]1,character\f043.png,400,200,300,400
[dial]阿灰,你是第一次來吧？歡迎來到 AVG Creator 的世界，接下來就讓我帶你到處走走逛逛囉！,icon\f043.png
[next]
[dial]阿灰,AVG Creator 是一款開放、簡單、易用的冒險故事遊戲引擎，只要學會簡易的腳本就能建立一款自己的 AVG 遊戲,icon\f043.png
[next]
[dial]阿灰,不需要懂得複雜的程式設計，只要將相應的參數放到腳本上，就能順利地做出遊戲了喔！,icon\f043.png
[next]
[dial]阿灰,接下來，我要召喚出我的好朋友給你認識，順便展示一下 AVG Creator 的威力！,icon\f043.png
[next]
[crcl]1
[char]1,character\f043.png,500,200,300,400
[char]2,character\f042.png,200,200,300,400
[dial]阿灰,這是灰灰，牠是我養的狗～～灰灰，來打聲招呼,icon\f043.png
[next]
[plau]music\small_dog.mp3,70
[dial]灰灰,汪汪！,icon\f042.png
[next]
[dial]阿灰,真是的···原來不會說話啊,icon\f043.png
[next]
[dial]灰灰,······,icon\f042.png
[next]
[crcl]3
[char]1,character\f043.png,400,200,300,400
[dial]阿灰,就像你剛才看到的，AVG Creator 能夠自由地讓不同的角色登場，只要如此運用，就能製作出 AVG 遊戲了呢！不過精彩的還在後頭～,icon\f043.png
[next]
[plau]music\running1.mp3,70
[bgim]background\3_blacksmith_a.jpg
[dial]阿灰,想要像是這樣，在不同場景間過度也是非常容易的哦！,icon\f043.png
[next]
[dial]阿灰,肚子有點餓了，等一下要吃什麼才好呢？,icon\f043.png
[next]
[sect]飯,麵,不知道,吃土
[next]
[answ]70,73,76,79
[dial]阿灰,好喔！中午就來吃飯吧～～,icon\f043.png
[next]
[goto]83
[dial]阿灰,好喔！中午就來吃麵吧～～,icon\f043.png
[next]
[goto]83
[dial]阿灰,啊？可是你這樣我會很困擾呢 ><,icon\f043.png
[next]
[goto]83
[dial]阿灰,不要啦～～人家不要吃土QAQ,icon\f043.png
[next]
[goto]83
[next]
[dial]阿灰,吃飽了～～接下來該做什麼呢,icon\f043.png
[next]
[dial]阿灰,（其實剛才只是為了示範選項而吃的飯啊···）,icon\f043.png
[next]
[crcl]1
[char]2,character\f344.png,500,200,300,400
[char]1,character\f043.png,200,200,300,400
[dial]小生,你這笨蛋，待在這裡幹嘛？,icon\f344.png
[next]
[dial]阿灰,······你說誰是笨蛋,icon\f043.png
[next]
[dial]小生,你不覺得你那個樣子···看起來特別蠢嗎？,icon\f344.png
[next]
[dial]小生,還有，你真的有好好跟人家介紹 AVG Creator 該怎麼使用嗎？,icon\f344.png
[next]
[dial]阿灰,······,icon\f043.png
[next]
[dial]小生,你要是害他對這個軟體沒興趣了該怎麼辦？嗯？你要負起責任嗎？,icon\f344.png
[next]
[dial]小生,你知道軟體作者花了一天又一個下午的時間來開發 AVG Creator 嗎？,icon\f344.png
[next]
[dial]阿灰,（真短啊······）,icon\f043.png
[next]
[dial]阿灰,（啊，對了，既然作者在的話，能不能幫我把小生變不見？）,icon\f043.png
[next]
[sect]好啊,才不要,null,null
[next]
[answ]112,117,null,null
[next]
[crcl]2
[dial]阿灰,呼···真是謝了，之前他問我要不要一起去煙火大會，結果好像不小心把他弄生氣了，真討厭呢 ><,icon\f043.png
[next]
[goto]123
[next]
[dial]小生,你想把我變不見？嗯？（笑）,icon\f344.png
[next]
[dial]阿灰,哪有這種事情啊～哈哈哈哈哈哈哈哈哈哈（尷尬）,icon\f043.png
[next]
[dial]小生,嗯？,icon\f344.png
[next]
[dial]阿灰,大致上，這就是 AVG Creator 能做到的功能囉！如果對於自己製作 AVG 遊戲有興趣的話，不妨也來試試看吧！對了，要特別提一下，這次的圖片素材是由《星宝転生ジュエルセイバー》所提供，想要製作自己的遊戲時，也要注意版權問題哦！,icon\f043.png
[next]
[dial]阿灰,本次介紹到此結束！,icon\f043.png
```