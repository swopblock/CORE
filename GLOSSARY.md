#Glossary

SUBJECTS

"Subjects" is a cast of Users, Invoicers, Autos, Receipters.

"Incenters" is an Incenting cast of Invoicers and Receipters.

"Consenters" is a Consenting cast of Incenters.

"Internetters" is an Internetting cast of all Subjects.

"Users" Bid Money and Ask Money to make Offers of exchange Orders between Buyers and Sellers.

"Invoicers" Match Offers to make Invoices of exchange Orders between Buyers and Sellers.

"Autoers" Fill Invoices to make Deliveries of exchange Orders between Buyers and Sellers.

"Receipters" Confirm Deliveries of exchange Orders between Buyers and Sellers.

VERBS

"Bid" is executed by an Offering cast of Users to make an Offer with Money in order to Buy an Asset from another User.

"Ask" is executed by an Offering cast Users to make an Offer with Assets in order to Sell an Asset to another User.

"Buy" is executed by an Invoicing cast of Invoicers to make an Invoice.

"Sell" is executed by an Invoicing cast of Invoicers to make an Invoice.

"Pay" is executed by an Automating cast of Autoers as a Buyer to accept a Delivery of Assets from a Seller and make a Delivery of Money to the Seller.

"Cash" is executed by a Cashing cast of Autoers as a Seller to make a Delivery of Assets to a Buyer and accept a Delivery of Money from the Buyer.

"Expense" is executed by an Expensing cast of Receipters to make a Reciept to confirm to the Buyer that the Invoice is settled.

"Income" is executed by an Incoming cast of Receipters to make a Receipt to confirm to the Seller that the Invoice is settled.

"Text" is executed by a Texting cast of Users to send Offer Texts to Invoicers, by Invoicers to send Invoice Texts to Autos, by Autos to send Delivery Texts to Receipters and by Receipters to send Receipt Texts to Users.

"Signal" is executed just like Texting except Signals are sent instead of Texts. 

"Parse" is executed by a Parsing cast of Subjects to deserialize Texts or Signals back into the original object.

"Send" is executed by a Sending cast of Internetter to send Texts or Signals from Internetters.

"Receive" is executed by a Receiving cast of Internetters to receive Texts or Signals from Internetters.


OBJECTS

An "Order" is the set of people, actions, assets and money that result in the giving up of one person's assets in exchange for receiving another person's assets. Each Order starts empty and progressively becomes, first an Offer, then an Invoice, next a Delivery and finally a Receipt to result in the completion and the confirmation of the exchange. 

"Texts" are expressions of Orders serialized into a string of characters that form a sentence of English words.

"Signals" are expressions of Orders serialized into a string of bits that form a sequence of binary enumerations, indexes and numbers. 

A "Buy" is a kind of Order where the Offer is a bid of money in order to buy an asset in exchange for the money.

A "Sell" is a kind of Order where the Offer is an ask of money in order to sell an asset in exchange for the money.

An "Asset" is a valuable that is committable and transferable using a blockchain.

"Money" is a medium of value that is committable and transferable concurrently with the transfer of an Asset.

An "Offer" is a bidding or asking as a committment of Money or Assets (respectively), the bidding being a offering of Money in exchange for Assets, the asking being an offering of Assets in exchange for Money.

An "Invoice" is a matching of committments made in Offers and is a pair of matched Bid and Ask Offers such that the amount of Money being bid is exactly equal to the amount of Money being asked and is a confirmation that an Order has been made executable.

A "Delivery" is a fulfiling of committments matched in Invoices and is a concurrent cross-chain delivery of the money and same-chain delivery of the asset, the money and the asset that has been paired in the Bid and Ask twin Offers of an Invoice.

A "Receipt" is a confirming of the committments fulfilled in Deliveries.
