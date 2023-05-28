-- Mock data to test Tag and Date searching 
INSERT INTO Questions
VALUES (50, 'I''m testing', 'Checking dates yo', 'Computer Science', '04/18/2023');

INSERT INTO Questions
VALUES (51, 'I''m testing2', 'Checking dates yo', 'Computer Science', '04/17/2023');

INSERT INTO Questions
VALUES (52, 'I''m testing3', 'Checking dates yo', 'Cybersecurity', '04/16/2023');

INSERT INTO Questions
VALUES (53, 'I''m testing4', 'Checking dates yo', 'Information Systems', '04/15/2023');

INSERT INTO Questions
VALUES (54, 'I''m testing5', 'Checking dates yo', 'Information Technology', '04/14/2023');

-- Deleting data
DELETE FROM Questions
WHERE QuestionID >= 50;