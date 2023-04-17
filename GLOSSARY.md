#Glossary

SUBJECTS

"Subjects" is an abstraction of Users, Invoicers, Autos and Receipters.

"Incenters" is an abstraction of Invoicers and Receipters that focuses on the incentives of Ordering.

"Consenters" is a division of Incenters that focuses on the consensus of Ordering.

"Users" Bid Money and Ask Money to make Offers of exchange Orders between Buyers and Sellers.

"Invoicers" Match Offers to make Invoices of exchange Orders between Buyers and Sellers.

"Autos" Fill Invoices to make Deliveries of exchange Orders between Buyers and Sellers.

"Receipters" Confirm Deliveries of exchange Orders between Buyers and Sellers.

VERBS

"Bidding" is executed by Users to make an Offer with Money in order to Buy an Asset from another User.

"Asking" is executed by Users to make an Offer with Assets in order to Sell an Asset to another User.

"Buying" is executed by Invoicers to make an Invoice with a Bid and a matching Ask.

"Selling" is executed by Invoicers to make an Invoice with an Ask and a matching Bid.

"Paying" is executed by Autos as a Buyer to accept a Delivery of Assets from a Seller and make a Delivery of Money to the Seller.

"Cashing" is executed by Autos as a Seller to make a Delivery of Assets to a Buyer and accept a Delivery of Money from the Buyer.

"Expensing" is executed by Receipters to make a Reciept to confirm to the Buyer that the Invoice is settled.

"Incoming" is executed by Receipters to make a Receipt to confirm to the Seller that the Invoice is settled.

"Texting" is executed by Users to send Offer Texts to Invoicers, is executed by Invoicers to send Invoice Texts to Autos, is executed by Autos to send Delivery Texts to Receipters and is executed by Receipters to send Receipt Texts to Users.

"Signaling" is executed just like Texting except Signals are sent instead of Texts. 

"Parsing" is executed to deserialize a Text or a Signal back into it's original object.


OBJECTS

An "Order" is the set of people, actions, assets and money that result in the giving up of one person's assets in exchange for receiving another person's assets. Each Order starts empty and progressively becomes, first an Offer, then an Invoice, next a Delivery and finally a Receipt to result in the completion and the confirmation of the exchange. 

A "Text" is an expression of an Order serialized into a string of characters that form a sentence of English words.

A "Signal" is an expression of an Order serialized into a string of bits that form a sequence of binary enumerations, indexes and numbers. 

A "Buy" is a kind of Order where the Offer is a bid of money in order to buy an asset in exchange for the money.

A "Sell" is a kind of Order where the Offer is an ask of money in order to sell an asset in exchange for the money.

An "Asset" is a valuable that is committable and transferable using a blockchain.

"Money" is a medium of value that is committable and transferable concurrently with the transfer of an Asset.

An "Offer" is a bidding or asking as a committment of Money or Assets (respectively), the bidding being a offering of Money in exchange for Assets, the asking being an offering of Assets in exchange for Money.

An "Invoice" is a matching of committments made in Offers and is a pair of matched Bid and Ask Offers such that the amount of Money being bid is exactly equal to the amount of Money being asked and is a confirmation that an Order has been made executable.

A "Delivery" is a fulfiling of committments matched in Invoices and is a concurrent cross-chain delivery of the money and same-chain delivery of the asset, the money and the asset that has been paired in the Bid and Ask twin Offers of an Invoice.

A "Receipt" is a confirming of the committments fulfilled in Deliveries.
