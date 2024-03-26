use kyrsovaya_v0;

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