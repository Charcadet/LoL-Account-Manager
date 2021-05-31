# LoL Account Manager v2.0.2

![This is the README's header image :)](https://i.imgur.com/RXx32Yh.png)

LoL Account Manager v2.0.2 is an account storing utility program for people who play on multiple League of Legends accounts with different ranks. The main purpose of this program is to eliminate the need to login to all your accounts one by one until you find one that is in the ranked bracket you are looking to play in. With one glance of an eye you can see all your account ranks and copy the login to your clipboard to get ready to play immediately. 

LoL Account Manager is licensed under the Mozilla Public License 2.0 (MPL2).
## How does it work
You start off by adding an account by pressing the "Add account" button.
Which will present you the following form: 

![Add Account form](https://i.imgur.com/C3R0aow.png)

After adding your account the program stores it in a .json file and uses the Riot Games API to request the current rank and LP of the account (https://developer.riotgames.com/apis)

It will instantly show your accounts their Region, Username, IGN, Rank & Winrate,
![Screenshot](https://i.imgur.com/IhILK6S.png)

To run this program you will need a valid Riot Developer API key which you can request at https://developer.riotgames.com/ which you need to put in the code before compiling.

## Are the passwords encrypted?

Yes. The passwords stored in accountData.json are encrypted using AES-256

## Can I download this and use it?
Sadly, not really. To use this you will need a Riot Developer API key. 
While you could request one at https://developer.riotgames.com/ you would have to change it multiple times a week and recompile. Unless you get a verified API key, which most likely wont be possible as you don't own this code.

## Disclaimer

LoL Account Manager isn’t endorsed by Riot Games and doesn’t reflect the views or opinions of Riot Games or anyone officially involved in producing or managing League of Legends. League of Legends and Riot Games are trademarks or registered trademarks of Riot Games, Inc. and League of Legends © Riot Games, Inc. 
LoL Account Manager is in no way affiliated with, associated with or endorsed by Riot Games, Inc

##
![Screenshot](https://i.imgur.com/I0CsZRT.png)
