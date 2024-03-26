use kyrsovaya_v0;

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
