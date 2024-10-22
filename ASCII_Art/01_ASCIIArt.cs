﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwischenProjekt_CW.ASCII_Art
{
    static class ASCIIArt
    {

        // Titles and Headings

        public static string titleArt = @"
   .-'''-.   ___    _ .-------.    ,---.  ,---..-./`) ,---.  ,---.   ____      .---.             .-./`)    .-'''-.   .---.        ____    ,---.   .--. ______      
  / _     \.'   |  | ||  _ _   \   |   /  |   |\ .-.')|   /  |   | .'  __ `.   | ,_|             \ .-.')  / _     \  | ,_|      .'  __ `. |    \  |  ||    _ `''.  
 (`' )/`--'|   .'  | || ( ' )  |   |  |   |  .'/ `-' \|  |   |  .'/   '  \  \,-./  )             / `-' \ (`' )/`--',-./  )     /   '  \  \|  ,  \ |  || _ | ) _  \ 
(_ o _).   .'  '_  | ||(_ o _) /   |  | _ |  |  `-'`""`|  | _ |  | |___|  /  |\  '_ '`)          `-'`""`(_ o _).   \  '_ '`)   |___|  /  ||  |\_ \|  ||( ''_'  ) | 
 (_,_). '. '   ( \.-.|| (_,_).' __ |  _( )_  |  .---. |  _( )_  |    _.-`   | > (_)  )            .---.  (_,_). '.  > (_)  )      _.-`   ||  _( )_\  || . (_) `. | 
.---.  \  :' (`. _` /||  |\ \  |  |\ (_ o._) /  |   | \ (_ o._) / .'   _    |(  .  .-'            |   | .---.  \  :(  .  .-'   .'   _    || (_ o _)  ||(_    ._) ' 
\    `-'  || (_ (_) _)|  | \ `'   / \ (_,_) /   |   |  \ (_,_) /  |  _( )_  | `-'`-'|___          |   | \    `-'  | `-'`-'|___ |  _( )_  ||  (_,_)\  ||  (_.\.' /  
 \       /  \ /  . \ /|  |  \    /   \     /    |   |   \     /   \ (_ o _) /  |        \         |   |  \       /   |        \\ (_ o _) /|  |    |  ||       .'   
  `-...-'    ``-'`-'' ''-'   `'-'     `---`     '---'    `---`     '.(_,_).'   `--------`         '---'   `-...-'    `--------` '.(_,_).' '--'    '--''-----'`     
";

        public static string mainMenuArt = @"
 __ __        _         __  __                  
|  \/  | __ _(_)_ __   |  \/  | ___ _ __  _   _ 
| |\/| |/ _` | | '_ \  | |\/| |/ _ \ '_ \| | | |
| |  | | (_| | | | | | | |  | |  __/ | | | |_| |
|_|  |_|\__,_|_|_| |_| |_|  |_|\___|_| |_|\__,_|
";

        public static string aboutArt = @"
     _    _                 _   
    / \  | |__   ___  _   _| |_ 
   / _ \ | '_ \ / _ \| | | | __|
  / ___ \| |_) | (_) | |_| | |_ 
 /_/   \_\_.__/ \___/ \__,_|\__|
";

        public static string creditsArt = @"
 ____               _ _ _       
/ ___| _ __ ___  __| (_) |_ ___ 
| |   | '__/ _ \/ _` | | __/ __|
| |___| | |  __/ (_| | | |_\__ \
\_____|_|  \___|\__,_|_|\__|___/
";

        public static string exitArt = @"
 _____      _ _      ____                     ___ 
| ____|_  _(_) |_   / ___| __ _ _ __ ___   __|__ \
|  _| \ \/ / | __| | |  _ / _` | '_ ` _ \ / _ \/ /
| |___ >  <| | |_  | |_| | (_| | | | | | |  __/_| 
|_____/_/\_\_|\__|  \____|\__,_|_| |_| |_|\___(_) 
";

        public static string professionArt = @"
   ____ _                                                     ____             __               _             
  / ___| |__   ___   ___  ___  ___   _   _  ___  _   _ _ __  |  _ \ _ __ ___  / _| ___  ___ ___(_) ___  _ __  
 | |   | '_ \ / _ \ / _ \/ __|/ _ \ | | | |/ _ \| | | | '__| | |_) | '__/ _ \| |_ / _ \/ __/ __| |/ _ \| '_ \ 
 | |___| | | | (_) | (_) \__ \  __/ | |_| | (_) | |_| | |    |  __/| | | (_) |  _|  __/\__ \__ \ | (_) | | | |
  \____|_| |_|\___/ \___/|___/\___|  \__, |\___/ \__,_|_|    |_|   |_|  \___/|_|  \___||___/___/_|\___/|_| |_|
                                     |___/
";

        public static string nameArt = @"
 __        ___           _   _                                                          ___ 
 \ \      / / |__   __ _| |_( )___   _   _  ___  _   _ _ __   _ __   __ _ _ __ ___   __|__ \
  \ \ /\ / /| '_ \ / _` | __|// __| | | | |/ _ \| | | | '__| | '_ \ / _` | '_ ` _ \ / _ \/ /
   \ V  V / | | | | (_| | |_  \__ \ | |_| | (_) | |_| | |    | | | | (_| | | | | | |  __/_| 
    \_/\_/  |_| |_|\__,_|\__| |___/  \__, |\___/ \__,_|_|    |_| |_|\__,_|_| |_| |_|\___(_) 
                                     |___/
";

        public static string introArt = @"
  ___       _                 _            _   _             
 |_ _|_ __ | |_ _ __ ___   __| |_   _  ___| |_(_) ___  _ __  
  | || '_ \| __| '__/ _ \ / _` | | | |/ __| __| |/ _ \| '_ \ 
  | || | | | |_| | | (_) | (_| | |_| | (__| |_| | (_) | | | |
 |___|_| |_|\__|_|  \___/ \__,_|\__,_|\___|\__|_|\___/|_| |_|
";

        public static string craftingArt = @"
   ____            __ _   _             
  / ___|_ __ __ _ / _| |_(_)_ __   __ _ 
 | |   | '__/ _` | |_| __| | '_ \ / _` |
 | |___| | | (_| |  _| |_| | | | | (_| |
  \____|_|  \__,_|_|  \__|_|_| |_|\__, |
                                  |___/ 
";

        public static string craftToolsArt = @"
  _____           _     
 |_   _|__   ___ | |___ 
   | |/ _ \ / _ \| / __|
   | | (_) | (_) | \__ \
   |_|\___/ \___/|_|___/
";

        public static string craftRaftPartsArt = @"
  ____        __ _     ____            _       
 |  _ \ __ _ / _| |_  |  _ \ __ _ _ __| |_ ___ 
 | |_) / _` | |_| __| | |_) / _` | '__| __/ __|
 |  _ < (_| |  _| |_  |  __/ (_| | |  | |_\__ \
 |_| \_\__,_|_|  \__| |_|   \__,_|_|   \__|___/
";

        public static string yesNoArt = @"
     _                                                     ___ 
    / \   _ __ ___   _   _  ___  _   _   ___ _   _ _ __ __|__ \
   / _ \ | '__/ _ \ | | | |/ _ \| | | | / __| | | | '__/ _ \/ /
  / ___ \| | |  __/ | |_| | (_) | |_| | \__ \ |_| | | |  __/_| 
 /_/   \_\_|  \___|  \__, |\___/ \__,_| |___/\__,_|_|  \___(_) 
                     |___/
";

        public static string endArt = @"
  _____ _            _____           _ 
 |_   _| |__   ___  | ____|_ __   __| |
   | | | '_ \ / _ \ |  _| | '_ \ / _` |
   | | | | | |  __/ | |___| | | | (_| |
   |_| |_| |_|\___| |_____|_| |_|\__,_|
";

        public static string endDayArt = @"
  _____ _                _                              _           
 |_   _| |__   ___    __| | __ _ _   _    ___ _ __   __| |___       
   | | | '_ \ / _ \  / _` |/ _` | | | |  / _ \ '_ \ / _` / __|      
   | | | | | |  __/ | (_| | (_| | |_| | |  __/ | | | (_| \__ \_ _ _ 
   |_| |_| |_|\___|  \__,_|\__,_|\__, |  \___|_| |_|\__,_|___(_|_|_)
                                 |___/                              
";

        public static string newDayArt = @"
     _                                _               _                _                 
    / \     _ __   _____      __   __| | __ _ _   _  | |__   ___  __ _(_)_ __  ___       
   / _ \   | '_ \ / _ \ \ /\ / /  / _` |/ _` | | | | | '_ \ / _ \/ _` | | '_ \/ __|      
  / ___ \  | | | |  __/\ V  V /  | (_| | (_| | |_| | | |_) |  __/ (_| | | | | \__ \_ _ _ 
 /_/   \_\ |_| |_|\___| \_/\_/    \__,_|\__,_|\__, | |_.__/ \___|\__, |_|_| |_|___(_|_|_)
                                              |___/              |___/                   
";

        public static string gameOverArt = @"
  .-_'''-.      ____    ,---.    ,---.    .-''-.              ,-----.    ,---.  ,---.   .-''-.  .-------.     
 '_( )_   \   .'  __ `. |    \  /    |  .'_ _   \           .'  .-,  '.  |   /  |   | .'_ _   \ |  _ _   \    
|(_ o _)|  ' /   '  \  \|  ,  \/  ,  | / ( ` )   '         / ,-.|  \ _ \ |  |   |  .'/ ( ` )   '| ( ' )  |    
. (_,_)/___| |___|  /  ||  |\_   /|  |. (_ o _)  |        ;  \  '_ /  | :|  | _ |  |. (_ o _)  ||(_ o _) /    
|  |  .-----.   _.-`   ||  _( )_/ |  ||  (_,_)___|        |  _`,/ \ _/  ||  _( )_  ||  (_,_)___|| (_,_).' __  
'  \  '-   .'.'   _    || (_ o _) |  |'  \   .---.        : (  '\_/ \   ;\ (_ o._) /'  \   .---.|  |\ \  |  | 
 \  `-'`   | |  _( )_  ||  (_,_)  |  | \  `-'    /         \ `""/  \  ) /  \ (_,_) /  \  `-'    /|  | \ `'   / 
  \        / \ (_ o _) /|  |      |  |  \       /           '. \_/``"".'    \     /    \       / |  |  \    /  
   `'-...-'   '.(_,_).' '--'      '--'   `'-..-'              '-----'       `---`      `'-..-'  ''-'   `'-'   
";

        public static string winArt= @"
   ____     __   ,-----.      ___    _            .-'''-.   ___    _ .-------.    ,---.  ,---..-./`) ,---.  ,---.   .-''-.   ______      
   \   \   /  /.'  .-,  '.  .'   |  | |          / _     \.'   |  | ||  _ _   \   |   /  |   |\ .-.')|   /  |   | .'_ _   \ |    _ `''.  
    \  _. /  '/ ,-.|  \ _ \ |   .'  | |         (`' )/`--'|   .'  | || ( ' )  |   |  |   |  .'/ `-' \|  |   |  .'/ ( ` )   '| _ | ) _  \ 
     _( )_ .';  \  '_ /  | :.'  '_  | |        (_ o _).   .'  '_  | ||(_ o _) /   |  | _ |  |  `-'`""`|  | _ |  |. (_ o _)  ||( ''_'  ) | 
 ___(_ o _)' |  _`,/ \ _/  |'   ( \.-.|         (_,_). '. '   ( \.-.|| (_,_).' __ |  _( )_  |  .---. |  _( )_  ||  (_,_)___|| . (_) `. | 
|   |(_,_)'  : (  '\_/ \   ;' (`. _` /|        .---.  \  :' (`. _` /||  |\ \  |  |\ (_ o._) /  |   | \ (_ o._) /'  \   .---.|(_    ._) ' 
|   `-'  /    \ `""/  \  ) / | (_ (_) _)        \    `-'  || (_ (_) _)|  | \ `'   / \ (_,_) /   |   |  \ (_,_) /  \  `-'    /|  (_.\.' /  
 \      /      '. \_/``"".'   \ /  . \ /         \       /  \ /  . \ /|  |  \    /   \     /    |   |   \     /    \       / |       .'   
  `-..-'         '-----'      ``-'`-''           `-...-'    ``-'`-'' ''-'   `'-'     `---`     '---'    `---`      `'-..-'  '-----'`     
";

        public static string disclaimerArt = @"
  ____  _          _       _                     
 |  _ \(_)___  ___| | __ _(_)_ __ ___   ___ _ __ 
 | | | | / __|/ __| |/ _` | | '_ ` _ \ / _ \ '__|
 | |_| | \__ \ (__| | (_| | | | | | | |  __/ |   
 |____/|_|___/\___|_|\__,_|_|_| |_| |_|\___|_|   
";


        // Scene Art

        public static string beachArt = @"
          |
        \ _ /
      -= (_) =-
        /   \         _\/_
          |           //o\      _\/_
   _____ _ __ __ ____ _ | __  _ /o\\ 
 =-=-_-__=_-= _=_=-=_,-'|""'""""-|-,_
  =- _=-=- -_=-=_,-""            |
    =- =- -=.--""
";

        public static string riverArt = @"
                  _.._
   _________....-~    ~-.______
~~~                            ~~~~-----...___________..--------
                                           |   |     |
                                           | |   |  ||
                                           |  |  |   |
                                           |'. .' .`.|
___________________________________________|0oOO0oO0o|____________
 -          -         -       -      -    / '  '. ` ` \    -    -
      --                  --       --   /    '  . `   ` \    --
---            ---          ---       /  '                \ ---
     ----               ----        /       ' ' .    ` `    \  ----
-----         -----         ----- /   '   '        `      `   \
                     ------     /          '    . `     `    `  \
            -------           /  '    '      '      `
                    --------/     '     '   '
";

        public static string jungleArt = @"
               ,@@@@@@@,
       ,,,.   ,@@@@@@/@@,  .oo8888o.
    ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o
   ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'
   %&&%&%&/%&&%@@\@@/ /@@@88888\88888'
   %&&%/ %&%%&&@@\ V /@@'|`88\8 `/88|
   `&%\ ` /%&'| | |.|    |   \ '|8' |
    |  |o|    |   | |    |    | |   |
       |.|        | |         | |  
    \\/ ._\-\|/- /  ,\_//__\\/.  \_//__/_
";

        public static string hillsArt = @"
          /\
         /**\
        /****\   /\
       /      \ /**\
      /  /\    /    \        /\    /\  /\      /\            /\/\/\  /\
     /  /  \  /      \      /  \/\/  \/  \  /\/  \/\  /\  /\/ / /  \/  \
    /  /    \/ /\     \    /    \ \  /    \/ /   /  \/  \/  \  /    \   \
   /  /      \/  \/\   \  /      \    /   /    \
__/__/_______/___/__\___\__________________________________________________
";

        public static string grasslandsArt = @"
                    _
                  _(_)_                          wWWWw   _
      @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_
     @@()@@ wWWWw  (_)\    (___)   _(_)_  @@()@@   Y  (_)@(_)
      @@@@  (___)     `|/    Y    (_)@(_)  @@@@   \|/   (_)\
       /      Y       \|    \|/    /(_)    \|      |/      |
    \ |     \ |/       | / \ | /  \|/       |/    \|      \|/
    \\|//   \\|///  \\\|//\\\|/// \|///  \\\|//  \\|//  \\\|// 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
";

        public static string caveArt = @"";


        public static string sunsetArt = @"
           ^^                    @@@@@@@@@
       ^^       ^^            @@@@@@@@@@@@@@@
                            @@@@@@@@@@@@@@@@@@              ^^
                           @@@@@@@@@@@@@@@@@@@@
 ~~~~ ~~ ~~~~~ ~~~~~~~~ ~~ &&&&&&&&&&&&&&&&&&&& ~~~~~~~ ~~~~~~~~~~~ ~~~
 ~         ~~   ~  ~       ~~~~~~~~~~~~~~~~~~~~ ~       ~~     ~~ ~
   ~      ~~      ~~ ~~ ~~  ~~~~~~~~~~~~~ ~~~~  ~     ~~~    ~ ~~~  ~ ~~
   ~  ~~     ~         ~      ~~~~~~  ~~ ~~~       ~~ ~ ~~  ~~ ~
 ~  ~       ~ ~      ~           ~~ ~~~~~~  ~      ~~  ~             ~~
       ~             ~        ~      ~      ~~   ~             ~
";

        public static string sunriseArt = @"
                                          
                                              
        ^^                       .:::::::.                  ^^
             ^^               .:::::::::::::.  
 ____________________________.:::::::::::::::.________________________
                              ~~ ~~~~~  ~~~~                        
       ~                         ~~ ~~~~~               ~           ~   
                      ~                                           
                                                                       
                 ~                       ~                       ~
";
    }
}