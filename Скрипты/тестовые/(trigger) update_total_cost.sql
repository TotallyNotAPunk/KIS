DELIMITER //

CREATE TRIGGER update_total_cost
AFTER INSERT ON shopping_cart
FOR EACH ROW
BEGIN
    UPDATE shopping_cart sc
    SET total_cost = (SELECT cost FROM game WHERE game_id = NEW.game_game_id) * NEW.quantity
    WHERE product_id = NEW.product_id;
END //

DELIMITER ;