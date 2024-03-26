use kyrsovaya_v0;

SELECT g.*
FROM game g
JOIN publisher p ON g.publisher_publisher_id = p.publisher_id
WHERE p.publisher_name = 'Paradox Interactive';