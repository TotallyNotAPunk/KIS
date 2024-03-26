use kyrsovaya_v0;
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
    
SELECT * FROM game_summary;