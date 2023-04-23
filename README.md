# CORE

March 2, 2023 Jeff: Getting started with text messaging io for order. Plan to get all text messaging io working each of the four processing units: order, invoice, change and confirm.

Text messaging examples:

Order: I am bidding 10 SWOBL using my BTC address 0xFF in order for buying ETH using the market.
Invoice: ... to be continued ...

March 3, 2023 Jeff: Adding expiration and signature to the user ordering grammar over at the swopblock/ActionGrammar project. Did add some test offer stuff here.

March 6, 2023 Jeff: Reorganized and flushed out ordering, invoicing, delivering (was changing (added deliver project and deleted change project) and confirming over at the swopblock/ActionGrammar project.

March 13, 2023 Jeff: Working on 20+ classes to represent the the order, invoice, delivery and confirmation messages.

March 14, 2023 Jeff: Expanded the confirmation message to include market account and inventory information.

March 17, 2023 Jeff: Renaming projects to Swop-Script and CORE and continuing to add tests to Swop-Script

April 14, 2023 Jeff: Top level restructuring: Users, Invoicers, Autos and Receipters are the top level processors. Orders is the kind of messages there are, the messages being: Offers, Invoices, Deliveries and Receipts. 

April 22, 2023 Jeff: Factoring Swopblock software into (1) APP the mobile app implementation of the application layer, (2) into swop {(s)aving, (w)ithdrawing and (o)rdering (p)rotocol} the console app implementation of the application layer, (3) into CORE the servers for processing the incentive, consensus and internet layers and (4) into Swop-Script the messaging library.
