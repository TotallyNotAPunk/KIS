use kyrsovaya_v0;

INSERT INTO `kyrsovaya_v0`.`web_store` (`web_store_id`, `web_store`, `web_addres`) VALUES ('1', 'Steam', 'store.steampowered.com');
INSERT INTO `kyrsovaya_v0`.`web_store` (`web_store_id`, `web_store`, `web_addres`) VALUES ('2', 'Epic Games', 'store.epicgames.com');

INSERT INTO `kyrsovaya_v0`.`inventory` (`inventory_id`, `web_store_web_store_id`) VALUES ('1', '1');
INSERT INTO `kyrsovaya_v0`.`inventory` (`inventory_id`, `web_store_web_store_id`) VALUES ('2', '2');

INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('1', 'Неизвестно');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('2', 'Швеция');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('3', 'Канада');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('4', 'США');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('5', 'Люксембург');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('6', 'Бразилия');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('7', 'Россия');
INSERT INTO `kyrsovaya_v0`.`country` (`country_id`, `country`) VALUES ('8', 'КНР');

INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('1', 'Неизвестно', '1');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('2', 'Стокгольм', '2');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('3', 'Ванкувер', '3');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('4', 'Монреаль', '3');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('5', 'Гранд-Рапидс', '4');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('6', 'Балтимор', '4');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('7', 'Остин ', '4');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('8', 'Сиэтл', '4');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('9', 'Санта-Ана', '4');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('10', 'Люксембург', '5');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('11', 'Салвадор', '6');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('12', 'Санкт-Петербург', '7');
INSERT INTO `kyrsovaya_v0`.`city` (`city_id`, `city`, `country_country_id`) VALUES ('13', 'Пекин', '8');

INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('1', 'Paradox Interactive');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('2', 'Hinterland Studio Inc.');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('3', 'Red Hook Studios');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('4', 'Finji');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('5', 'Starbreeze Publishing AB');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('6', 'Goblinz Publishing');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('7', 'TrampolineTales');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('8', 'Versus Evil');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('9', 'Firecast Studio');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('10', 'Devolver Digital');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('11', 'Ska Studios');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('12', 'Killmonday Games AB');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('13', 'Pixeye Games');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('14', 'COGNOSPHERE PTE. LTD.');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('15', 'Double Stallion Games');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('16', 'Spiderweb Software');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('17', 'Righteous Hammer Games');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('18', 'Annapurna Interactive');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('19', 'HypeTrain Digital');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('20', 'The Irregular Corporation');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('21', 'Nicalis, Inc.');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('22', 'Raw Fury');
INSERT INTO `kyrsovaya_v0`.`publisher` (`publisher_id`, `publisher_name`) VALUES ('23', 'Kasedo Games');

INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('1', 'Tyranny — Gold Edition', 'Окунитесь в сюжетную ролевую игру, в которой ваш выбор является решающим. Tyranny — Gold Edition является самым полным набором игры Tyranny, включающим в себя все дополнения Tyranny и весь дополнительно загружаемый контент (DLC).', 2020, '1511', 'Mostly positive', '1', '1');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('2', 'The Long Dark', 'The Long Dark — это продуманная игра, фокусирующаяся на выживании и исследовании, где игрокам придется самим принимать решения, путешествуя по огромной холодной дикой местности, пережившей геомагнитную катастрофу. В ней нет зомби — только вы, стужа и то, что вам приготовила Мать-природа.', 2017, '619', 'Mostly positive', '1', '2');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('3', 'Darkest Dungeon®', 'Darkest Dungeon — сложная пошаговая ролевая roguelike-игра с готической атмосферой, в которой приключения персонажей сказываются на их душевном здоровье. Вам предстоит собрать, обучить и возглавить команду героев, у каждого из которых есть свои недостатки.', 2016, '880', 'Mostly positive', '1', '3');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('4', 'Night in the Woods', 'NIGHT IN THE WOODS is an adventure game focused on exploration, story, and character, featuring dozens of characters to meet and lots to do across a lush, vibrant world', 2017, '710', 'Mostly positive', '1', '4');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('5', 'PAYDAY 2', 'PAYDAY 2 - это кооперативный экшн-шутер для четверых игроков, который снова позволяет игрокам надеть маски оригинальной банды PAYDAY - Даллас, Хокстон, Чейнс и Вулф, которые прибыли в Вашингтон для новой крутой серии преступлений.', 2013, '385', 'Positive', '1', '5');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('6', 'Banners of Ruin', 'Соберите отряд. Ответьте на зов. Выиграйте войну. Соберите колоду и проложите себе путь через город Зари, участвуя в пошаговых карточных боях с отрядом из 6 персонажей.', 2021, '450', 'Positive', '1', '6');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('7', 'Удачи, арендодатель', '«Удачи, арендодатель» — это стратегия-симулятор в жанре roguelite, где нужно с помощью игрового автомата зарабатывать деньги на аренду и победить капитализм. Это не азартная игра, здесь нет ставок на реальные деньги и микротранзакций.', 2023, '385', 'Mostly positive', '1', '7');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('8', 'Yaga', 'Играйте за Ивана, за невероятно невезучего однорукого кузнеца, который должен выполнить невыполнимые задачи, данные ему царём. В то время, как таинственная ведьма Баба Яга следит за судьбой Ивана.', 2021, '950', 'Negative', '1', '8');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('9', 'Sword Legacy: Omen', 'В этом переложении мифов о короле Артуре вы примерите на себя роль рыцаря Утера, которому Мерлин помогает в поисках Экскалибура. Выживите в пошаговых битвах, путешествуя по опустошенной Британии.', 2018, '400', 'Mixed', '1', '9');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('10', 'Shadow Warrior Classic', 'The definitive version of the cult classic shooter, Shadow Warrior Classic Redux features remastered visuals and two massive expansion packs. Corporations rule every facet of life in a near-future Japan and employ Shadow Warriors, one-man armies of unparalleled skill, to protect their power and forcefully remove all opposition.', 1997, '385', 'Mostly positive', '1', '10');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('11', 'Salt and Sanctuary', 'Explore a haunting, punishing island in this stylized 2D action RPG. Salt and Sanctuary combines fast and brutal 2D combat with richly developed RPG mechanics in a cursed realm of forgotten cities, blood-soaked dungeons, and desecrated monuments.', 2016, '390', 'Positive', '1', '11');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('12', 'My Friend Pedro', 'My Friend Pedro — это жестокая смесь дружбы, фантазии и стремления уничтожить всех на своем пути по приказу разумного банана. Стратегическое использование раздельного прицеливания, замедленного движения и старого доброго вышибания окон позволяет выстраивать одну сногсшибательную боевую сцену за другой. Устройте себе взрывную проходку по беспощадному преступному миру.', 2019, '710', 'Mostly positive', '1', '10');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('13', 'The Messenger', 'Армия демонов осаждает родную деревню молодого ниндзя, вынуждая его отправиться в проклятый мир, чтобы доставить свиток, от которого зависит выживание его клана.', 2018, '710', 'Mostly positive', '1', '10');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('14', 'Fran Bow', 'Fran Bow is a creepy adventure game that tells the story of Fran, a young girl struggling with a mental disorder and an unfair destiny.', 2015, '350', 'Mostly positive', '1', '12');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('15', 'Until We Die', 'Until We Die - стратегия про защиту базы, где надо бегать Иваном, раздавать пинки подопечным и отбиваться лопатами от мутантов в постапокалиптическом метро!', 2021, '465', 'Mixed', '1', '13');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('16', 'Tyranny — Gold Edition', 'Окунитесь в сюжетную ролевую игру, в которой ваш выбор является решающим. Tyranny — Gold Edition является самым полным набором игры Tyranny, включающим в себя все дополнения Tyranny и весь дополнительно загружаемый контент (DLC).', 2020, '930', 'Mostly positive', '2', '1');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('17', 'The Long Dark', 'Вдумчивый игровой процесс, сосредоточенный на выживании и исследовании, где игрокам предстоит принимать самостоятельные решения и заботиться о себе, путешествуя по ледяной пустоши, пережившей геомагнитную катастрофу. Здесь только вы, вечный мороз и полный набор опасностей, которые приготовила для вас мать-природа.', 2020, '750', 'Mostly positive', '2', '2');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('18', 'Darkest Dungeon®', 'Darkest Dungeon® — сложная пошаговая ролевая roguelike-игра с готической атмосферой, в которой приключения персонажей сказываются на их душевном здоровье. Команду нужно будет провести по жутким лесам, опустевшим заповедникам, обрушенным склепам и другим опасным местам. Сражаться придётся не только с немыслимыми врагами, но и со стрессом, голодом, болезнями и непроглядной тьмой.', 2020, '550', 'Mostly positive', '2', '3');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('19', 'Night in the Woods', 'Night In The Woods — игра о бывшей студентке колледжа, которая после отчисления возвращается в родной город к своим старым друзьям. Сломайте что-нибудь, поиграйте на басу, поболтайтесь на улице и приготовьтесь раскрыть тайны, о которых вам лучше ничего не знать. С возвращением в Поссум-Спрингс.', 2020, '450', 'Mostly positive', '2', '4');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('20', 'PAYDAY 2', 'PAYDAY 2 — динамичный командный шутер для четырёх игроков, который вновь позволит геймерам надеть маски оригинальной команды PAYDAY — Далласа, Хокстона, Вольфа и Чейнса — и отправиться в столицу, чтобы радостно творить криминал.', 2020, '300', 'Positive', '2', '5');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('21', 'Honkai: Star Rail', 'Honkai: Star Rail — это новая космическая фантастика от HoYoverse, в которой игроки отправляются в космическое путешествие среди звёзд. Присоединитесь к экипажу Звёздного экспресса и окунитесь в бесконечные чудеса галактики в путешествии, полном захватывающих приключений и острых ощущений.', 2023, '0', 'Mostly positive', '2', '14');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('22', 'Speed Brawl', 'Speed Brawl — двухмерные боевые состязания для всех, кто умеет быстро бегать и крепко бить! Не сбавляйте темп, наращивайте серии ударов и используйте убойные спецприемы. Придумайте свой боевой стиль и создайте лучшую команду бойцов в мире. А потом повторите всё это быстрее… быстрее… ЕЩЁ БЫСТРЕЕ', 2018, '435', 'Positive', '2', '15');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('23', 'Geneforge 1 - Mutagen', 'Уникальная ролевая игра в стиле фэнтези с непривычным местом действия и открытым игровым процессом. Используйте силу или хитрость, чтобы менять мир вокруг себя, и повелевайте целой армией собственных мутантов. Вас ждут удивительные навыки, разные группировки, ещё раз сокровища и фантастические создания. Полная свобода действия, возможность многократного прохождения и эпический сюжет', 2021, '450', 'Positive', '2', '16');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('24', 'Solitairica', 'Solitairica сочетает в себе сражения ролевых игр и непростое прохождение, свойственное играм в жанре rogue-like, в совершенно новой обстановке — мире пасьянса! С помощью разнообразных волшебных предметов и заклинаний прорывайтесь через полчище постоянно меняющихся противников и повергните ужасного императора Стака (Stuck)!', 2020, '200', 'Mostly positive', '2', '17');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('25', 'Solar Ash', 'Создатели отмеченной множеством наград игры Hyper Light Drifter приглашают вас в сверхскоростной мир Solar Ash, где законы гравитации бессильны. Вам предстоит играть за Странницу пустоты (Voidrunner) по имени Рей (Rei), которая не остановится ни перед чем, ради того чтобы спасти свою планету, оказавшуюся на пути всепоглощающей Ультрабездны (Ultravoid).', 2021, '1250', 'Positive', '2', '18');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('26', 'Quasimorph', 'Возьми на себя роль опытного бойца частной военной компании в Quasimorph: мрачной пошаговой RPG с элементами extract roguelike. Сражайся в беспощадных боях, управляй своим кораблем и брось вызов мрачному миру будущего.', 2023, '700', 'Mixed', '2', '19');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('27', 'Murder by Numbers', 'Решайте пиксельные головоломки, чтобы найти подсказки. Используйте эти улики при допросе свидетелей. Найдите свой путь к правде и раскройте тайну отсчёта убийств в игре Murder by Numbers!', 2021, '350', 'Positive', '2', '20');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('28', 'Cave Story+', 'Cave Story+, вероятно, считается самой известной инди-игрой всех времён. Вас ждёт подлинный сюжет, полный своих особенностей и тайн, скучать здесь точно не придётся. Бегайте, прыгайте, стреляйте, летайте и открывайте новые пути в крупном приключенческом экшене в духе классических 8- и 16-битных игр!', 2020, '350', 'Mostly positive', '2', '21');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('29', 'Sable', 'Отправляйтесь в незабываемое священное путешествие вместе с Сэйбл, скользите через бескрайние пустыни и завораживающие пейзажи, осматривайте остовы космических кораблей и открывайте для себя чудеса древних цивилизаций.', 2021, '550', 'Positive', '2', '22');
INSERT INTO `kyrsovaya_v0`.`game` (`game_id`, `titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`) VALUES ('30', 'Filament', 'Решите непростые головоломки и выясните, что произошло с экипажем «Алебастрового». Теперь с системой подсказок (для самых сложных головоломок).', 2022, '550', 'Positive', '2', '23');

INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('1', 'Obsidian Entertainment');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('2', 'Hinterland Studio Inc.');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('3', 'Red Hook Studios');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('4', 'Infinite Fall');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('5', 'OVERKILL - a Starbreeze Studio.');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('6', 'MonteBearo');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('7', 'TrampolineTales');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('8', 'Breadcrumbs Interactive');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('9', 'Firecast Studio');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('10', '3D Realms');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('11', 'Ska Studios');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('12', 'DeadToast Entertainment');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('13', 'Sabotage');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('14', 'Killmonday Games AB');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('15', 'Pixeye Games');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('16', 'COGNOSPHERE PTE. LTD.');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('17', 'Double Stallion Games');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('18', 'Spiderweb Software');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('19', 'Righteous Hammer Games');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('20', 'Heart Machine');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('21', 'Magnum Scriptum');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('22', 'Mediatonic');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('23', 'Nicalis, Inc.');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('24', 'Shedworks');
INSERT INTO `kyrsovaya_v0`.`deviloper` (`deviloper_id`, `deviloper_name`) VALUES ('25', 'Beard Envy');

INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('1', '1');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('2', '2');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('3', '3');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('4', '4');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('5', '5');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('6', '6');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('7', '7');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('8', '8');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('9', '9');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('10', '10');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('11', '11');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('12', '12');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('13', '13');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('14', '14');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('15', '15');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('1', '16');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('2', '17');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('3', '18');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('4', '19');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('5', '20');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('16', '21');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('17', '22');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('18', '23');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('19', '24');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('20', '25');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('21', '26');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('22', '27');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('23', '28');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('24', '29');
INSERT INTO `kyrsovaya_v0`.`game_deviloper` (`deviloper_id`, `game_game_id`) VALUES ('25', '30');

INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('1', 'RPG', ' Жанр игр, где основой игрового процесса является отогревание определенной роли');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('2', 'Survival', 'Жанр компьютерных игр, разновидность симуляторов жизни, в которых основной целью игрока является сохранение жизни виртуального персонажа на фоне множества угрожающих ему опасностей');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('3', 'Roguelike', 'Жанр игр, в которых уровни при каждом забеге генерируются случайным образом, а персонаж после поражения теряет значительную часть прогресса');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('4', 'Adventure', 'Жанр компьютерных игр, представляющий собой интерактивную историю с главным героем, управляемым игроком');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('5', 'FPS', 'Жанр компьютерных игр, в которых игровой процесс основывается на сражениях с использованием огнестрельного или любого другого оружия с видом от первого лица таким образом, чтобы игрок воспринимал происходящее глазами протагониста.');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('6', 'Deck builder', 'Жанр игр, в которых игровой процесс основывается на построени \"колоды\" из карт или иных обектов, котрые позволят продвигаться в игре');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('7', 'Action', 'Жанр компьютерных игр, в котором делается упор на эксплуатацию физических возможностей игрока, таких как зрительно-моторная координация и скорость реакции');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('8', 'Strategy', 'Жанр компьютерных игр, в котором игроку для победы необходимо применять стратегическое мышление');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('9', 'Metroidvania', 'Жанр компьютерных игр, отличительной чертой которого является большой связный мир, доступный для исследования, хотя проходы к некоторым его частям перекрыты «дверями», «нехваткой информации» и другими барьерами, которые можно будет преодолеть, подобрав в другом месте мира подходящий инструмент или изучив способность.');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('10', 'Point and click', 'Жанр компьютерных игр, поджанр адвенчур, но с упором на изучение игровых локаций посредством курсора.');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('11', 'Platformer', 'Жанр компьютерных игр, в которых основу игрового процесса составляют прыжки по платформам, лазанье по лестницам, сбор предметов, необходимых для победы над врагами или завершения уровня.');
INSERT INTO `kyrsovaya_v0`.`tag` (`tag_id`, `tag_name`, `description`) VALUES ('12', 'Puzzle', 'Жанр компьютерных игр, целью которых является решение логических задач, требующих от игрока задействования логики');

INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('1', '1');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('2', '2');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('3', '3');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('4', '4');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('5', '5');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('3', '6');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('6', '7');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('7', '8');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('8', '9');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('5', '10');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('9', '11');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('7', '12');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('9', '13');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('10', '14');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('8', '15');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('1', '16');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('2', '17');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('3', '18');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('4', '19');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('5', '20');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('4', '21');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('11', '22');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('1', '23');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('6', '24');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('7', '25');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('8', '26');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('4', '27');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('11', '28');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('4', '29');
INSERT INTO `kyrsovaya_v0`.`game_tag` (`tag_tag_id`, `game_id`) VALUES ('12', '30');

INSERT INTO `kyrsovaya_v0`.`bill` (`bill_id`, `bill_sum`) VALUES ('1', '0');


CREATE VIEW game_summary AS
SELECT
    g.game_id,
    g.titel,
    g.description,
    g.release_year,
    g.cost,
    g.reviews,
    d.deviloper_name AS developer_name,
    p.publisher_name,
    ws.web_store
FROM
    game g
JOIN
    game_deviloper gd ON g.game_id = gd.game_game_id
JOIN
    deviloper d ON gd.deviloper_id = d.deviloper_id
JOIN
    publisher p ON g.publisher_publisher_id = p.publisher_id
JOIN
    inventory i ON g.inventory_inventory_id = i.inventory_id
JOIN
    web_store ws ON i.web_store_web_store_id = ws.web_store_id;
    

CREATE VIEW shopping_cart_summary AS
SELECT
    sc.product_id,
    g.titel AS game_title,
    w.web_store AS store_name,
    g.description,
    g.cost,
    b.bill_sum
FROM
    shopping_cart sc
JOIN
    game g ON sc.game_game_id = g.game_id
JOIN
    inventory i ON g.inventory_inventory_id = i.inventory_id
JOIN
    web_store w ON i.web_store_web_store_id = w.web_store_id
JOIN
    bill b ON sc.bill_bill_id = b.bill_id;

DELIMITER //

CREATE TRIGGER update_bill_sum
AFTER INSERT ON shopping_cart
FOR EACH ROW
BEGIN
    UPDATE bill
    SET bill_sum = bill_sum + (
        SELECT cost
        FROM game
        WHERE game_id = NEW.game_game_id
    )
    WHERE bill_id = NEW.bill_bill_id;
END //

DELIMITER ;

DELIMITER //

CREATE TRIGGER update_bill_sum_on_delete
AFTER DELETE ON shopping_cart
FOR EACH ROW
BEGIN
    UPDATE bill
    SET bill_sum = bill_sum - (
        SELECT cost
        FROM game
        WHERE game_id = OLD.game_game_id
    )
    WHERE bill_id = OLD.bill_bill_id;
END //

DELIMITER ;