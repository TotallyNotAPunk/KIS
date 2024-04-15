use kyrsovaya_kis;

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
