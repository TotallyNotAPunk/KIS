use kyrsovaya_v0;
SELECT g.*
FROM game g
JOIN inventory i ON g.inventory_inventory_id = i.inventory_id
JOIN web_store ws ON i.web_store_web_store_id = ws.web_store_id
WHERE ws.web_store = 'Steam';