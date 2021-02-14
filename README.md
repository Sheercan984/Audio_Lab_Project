# Audio_Lab_Project
Podczas poruszania losowany jest dźwięk kroków z puli w zależności od powierzchni na jakiej znajduje się postać (miękka, twarda). Do odgrywania kroków wykorzystany jest tylko jeden AudioSource ze względu na to że grać może tylko jeden dźwięk kroków na raz wiec nie ma potrzeby na większą ilość AudioSourców. W AudioMixerze podział na grupy jest następujący: 
    •	Master – w niej znajdują się wszystkie grupy, poprzez zmianę głośności tej grupy możemy ściszać lub podgłośnić wszystkie dźwięki występujące w grze.
    •	Music – w tej grupie odtwarzania jest muzyka w grze.
    •	Ambience – w tej grupie odtwarzane są dźwięki tła
    •	Character – ta grupa służy do sterowania głośnością wszystkich dźwięków postaci
        o	Footsteps – w tej grupie odtwarzane są dźwięki kroków postaci
        o	Jump – w tej grupie odtwarzane są dźwięki związane ze skokiem postaci (skok,lądowanie)
    •	Sequence – w tej grupie są odtwarzane dźwięki z cutscenki
AudioMixer posiada dwa Snapshoty pomiędzy którymi przełącza się w momencie kiedy postać gracza wejdzie w Trigger. Dźwięki tła (Ambience) posiadają opcję Spatial Blend ustawioną na 3D po ty by dźwięk narastał w miarę zbliżania się do centrum danej lokacji. Dźwięki te mają również ustawiony parametr Spread na 60° po to by złagodzić efekt twardej panoramy. Na scenie znajduje się również Audio Reverb Zone z presetem ustawionym na Cave po ty by dodać efekt echa/pogłosu.
