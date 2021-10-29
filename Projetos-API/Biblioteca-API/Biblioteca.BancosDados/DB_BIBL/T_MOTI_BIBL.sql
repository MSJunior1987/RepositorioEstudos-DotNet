# ==== Criacao da tabela ==== #
CREATE TABLE T_MOTI_BIBL(
	COD_MOTI  INT NOT NULL AUTO_INCREMENT,
    NOME_MOTI VARCHAR(30) NOT NULL,      
    PRIMARY KEY (COD_MOTI)
) DEFAULT CHARSET = utf8;

# ==== Insert de registros ==== #
INSERT INTO T_MOTI_BIBL (NOME_MOTI)
VALUES  ('Compra'), 
		('Venda'),
        ('Perca'), 
        ('Furto');
        
# ==== Select de testes ==== #        
SELECT COD_MOTI, NOME_MOTI
FROM T_MOTI_BIBL       