CREATE VIEW shopping_cart_view AS
SELECT
    sc.product_id,
    g.titel AS game_title,
    ws.web_store AS store_name,
    g.description,
    g.cost,
    (g.cost * sc.quantity) AS total_cost
FROM
    shopping_cart sc
JOIN
    game g ON sc.game_game_id = g.game_id
JOIN
    inventory inv ON g.inventory_inventory_id = inv.inventory_id
JOIN
    web_store ws ON inv.web_store_web_store_id = ws.web_store_id;