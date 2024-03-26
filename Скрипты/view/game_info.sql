use kyrsovaya_v0;

CREATE VIEW game_info AS
SELECT g.titel, g.description, g.release_year, g.cost, g.reviews, p.publisher_name, d.deviloper_name, s.web_store
FROM game g
JOIN publisher p ON g.publisher_publisher_id = p.publisher_id
JOIN game_deviloper gd ON g.game_id = gd.game_game_id
JOIN deviloper d ON gd.deviloper_id = d.deviloper_id
JOIN inventory i ON g.inventory_inventory_id = i.inventory_id
JOIN web_store s ON i.web_store_web_store_id = s.web_store_id;

SELECT * FROM game_info;