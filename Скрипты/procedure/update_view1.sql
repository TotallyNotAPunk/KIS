use kyrsovaya_KIS;
DELIMITER //
CREATE PROCEDURE update_game_summary()
BEGIN
    DROP VIEW IF EXISTS game_summary;
    CREATE VIEW game_summary AS
	SELECT 
    g.game_id,
    g.titel,
    g.description,
    g.release_year,
    g.cost,
    g.reviews,
    d.developer_name AS developer_name,
    p.publisher_name AS publisher_name,
    ws.web_store AS web_store
	FROM 
    game g
	JOIN 
    developer d ON g.developer_developer_id = d.developer_id
	JOIN 
    publisher p ON g.publisher_publisher_id = p.publisher_id
	JOIN 
    inventory i ON g.inventory_inventory_id = i.inventory_id
	JOIN 
    web_store ws ON i.web_store_web_store_id = ws.web_store_id;
END//

DELIMITER ;