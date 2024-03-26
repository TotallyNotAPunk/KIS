use kyrsovaya_v0;

SELECT g.* FROM game g JOIN game_deviloper gd ON g.game_id = gd.game_game_id JOIN deviloper d ON gd.deviloper_id = d.deviloper_id WHERE d.deviloper_name = 'Obsidian Entertainment';

