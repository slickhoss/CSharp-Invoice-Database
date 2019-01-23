CREATE TABLE InvoiceDetail (detailId INT NOT NULL IDENTITY(1,1),
							quantity INT NOT NULL,
							sku VARCHAR(255) NOT NULL,
							description VARCHAR(255) NULL,
							price DECIMAL(18,2) NOT NULL,
							taxable bit NULL);