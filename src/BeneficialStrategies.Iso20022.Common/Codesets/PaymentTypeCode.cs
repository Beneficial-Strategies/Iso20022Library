// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z8T2KNp-Ed-ak6NoX_4Aeg_1153774680")]
[Description(@"Specifies the type, or nature, of the payment.")]
[Derivations(typeof(PaymentType3Code),typeof(PaymentType4Code))]
public enum PaymentTypeCode
{
    /// <summary>
    /// Transaction is a withdrawal/deposit of cash.
    /// Encoded/decoded by serializers as &quot;CSH&quot;.
    /// </summary>
    [EnumMember(Value = "CSH")]
    [IsoId("_Z8dnINp-Ed-ak6NoX_4Aeg_-1926468611")]
    [Description(@"Transaction is a withdrawal/deposit of cash.")]
    CashTransaction,
    
    /// <summary>
    /// Payment has an origin and a destination in the same country, and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPS&quot;.
    /// </summary>
    [EnumMember(Value = "DPS")]
    [IsoId("_Z8dnIdp-Ed-ak6NoX_4Aeg_-1926468303")]
    [Description(@"Payment has an origin and a destination in the same country, and is made in the currency of that country.")]
    DomesticPayment,
    
    /// <summary>
    /// Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPH&quot;.
    /// </summary>
    [EnumMember(Value = "DPH")]
    [IsoId("_Z8dnItp-Ed-ak6NoX_4Aeg_-1926468243")]
    [Description(@"Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.")]
    DomesticHighValuePayment,
    
    /// <summary>
    /// Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPP&quot;.
    /// </summary>
    [EnumMember(Value = "DPP")]
    [IsoId("_Z8dnI9p-Ed-ak6NoX_4Aeg_-1926468208")]
    [Description(@"Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.")]
    DomesticPriorityPayment,
    
    /// <summary>
    /// Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBS&quot;.
    /// </summary>
    [EnumMember(Value = "CBS")]
    [IsoId("_Z8dnJNp-Ed-ak6NoX_4Aeg_-1926468148")]
    [Description(@"Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.")]
    CrossBorderPayment,
    
    /// <summary>
    /// Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBP&quot;.
    /// </summary>
    [EnumMember(Value = "CBP")]
    [IsoId("_Z8dnJdp-Ed-ak6NoX_4Aeg_-1926468071")]
    [Description(@"Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    CrossBorderPriorityPayment,
    
    /// <summary>
    /// Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBH&quot;.
    /// </summary>
    [EnumMember(Value = "CBH")]
    [IsoId("_Z8dnJtp-Ed-ak6NoX_4Aeg_-1926467794")]
    [Description(@"Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.")]
    CrossBorderHighValuePayment,
    
    /// <summary>
    /// Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;TCS&quot;.
    /// </summary>
    [EnumMember(Value = "TCS")]
    [IsoId("_Z8dnJ9p-Ed-ak6NoX_4Aeg_-1926467741")]
    [Description(@"Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.")]
    ThirdCurrencyPayment,
    
    /// <summary>
    /// Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;TCH&quot;.
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_Z8dnKNp-Ed-ak6NoX_4Aeg_-1926467656")]
    [Description(@"Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.")]
    ThirdCurrencyHighValuePayment,
    
    /// <summary>
    /// Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.
    /// Encoded/decoded by serializers as &quot;TCP&quot;.
    /// </summary>
    [EnumMember(Value = "TCP")]
    [IsoId("_Z8dnKdp-Ed-ak6NoX_4Aeg_-1926467337")]
    [Description(@"Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.")]
    ThirdCurrencyPriorityPayment,
    
    /// <summary>
    /// Transaction is the settlement of a trade, eg, a securities transaction.
    /// Encoded/decoded by serializers as &quot;COR&quot;.
    /// </summary>
    [EnumMember(Value = "COR")]
    [IsoId("_Z8dnKtp-Ed-ak6NoX_4Aeg_-1926467252")]
    [Description(@"Transaction is the settlement of a trade, eg, a securities transaction.")]
    TradeSettlementPayment,
    
    /// <summary>
    /// Transaction isthe settlement of a foreign exchange deal.
    /// Encoded/decoded by serializers as &quot;FEX&quot;.
    /// </summary>
    [EnumMember(Value = "FEX")]
    [IsoId("_Z8nYINp-Ed-ak6NoX_4Aeg_-1926467182")]
    [Description(@"Transaction isthe settlement of a foreign exchange deal.")]
    ForeignExchange,
    
    /// <summary>
    /// Transaction is an equivalent amount relative to a currency conversion.
    /// Encoded/decoded by serializers as &quot;EQA&quot;.
    /// </summary>
    [EnumMember(Value = "EQA")]
    [IsoId("_Z8nYIdp-Ed-ak6NoX_4Aeg_-1926467080")]
    [Description(@"Transaction is an equivalent amount relative to a currency conversion.")]
    EquivalentAmount,
    
    /// <summary>
    /// Transaction is the payment of a specific amount of money lent by a creditor/lender.
    /// Encoded/decoded by serializers as &quot;LOA&quot;.
    /// </summary>
    [EnumMember(Value = "LOA")]
    [IsoId("_Z8nYItp-Ed-ak6NoX_4Aeg_-1926466785")]
    [Description(@"Transaction is the payment of a specific amount of money lent by a creditor/lender.")]
    Loan,
    
    /// <summary>
    /// Transaction is an amount of money transferred in repayment of loan.
    /// Encoded/decoded by serializers as &quot;LOR&quot;.
    /// </summary>
    [EnumMember(Value = "LOR")]
    [IsoId("_Z8nYI9p-Ed-ak6NoX_4Aeg_-1925546719")]
    [Description(@"Transaction is an amount of money transferred in repayment of loan.")]
    LoanRepayment,
    
    /// <summary>
    /// Transaction is a payment of securities.
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_Z8nYJNp-Ed-ak6NoX_4Aeg_-1925546624")]
    [Description(@"Transaction is a payment of securities.")]
    Securities,
    
    /// <summary>
    /// Transaction is a payment(s) resulting from a lock box service.
    /// Encoded/decoded by serializers as &quot;LBX&quot;.
    /// </summary>
    [EnumMember(Value = "LBX")]
    [IsoId("_Z8nYJdp-Ed-ak6NoX_4Aeg_-1925546521")]
    [Description(@"Transaction is a payment(s) resulting from a lock box service.")]
    LockBox,
    
    /// <summary>
    /// Transaction is a payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIV&quot;.
    /// </summary>
    [EnumMember(Value = "DIV")]
    [IsoId("_Z8nYJtp-Ed-ak6NoX_4Aeg_-1925546451")]
    [Description(@"Transaction is a payment of dividends.")]
    Dividend,
    
    /// <summary>
    /// Transaction is a crossed cheque. A crossed check has two parallel lines across its face, indicating that the cheque must be paid into an account and not cashed over the counter.
    /// Encoded/decoded by serializers as &quot;CSQ&quot;.
    /// </summary>
    [EnumMember(Value = "CSQ")]
    [IsoId("_Z8nYJ9p-Ed-ak6NoX_4Aeg_-1925546132")]
    [Description(@"Transaction is a crossed cheque. A crossed check has two parallel lines across its face, indicating that the cheque must be paid into an account and not cashed over the counter.")]
    CrossedCheque,
    
    /// <summary>
    /// Transaction is an uncrossed cheque that can be cashed at the bank of origin.
    /// Encoded/decoded by serializers as &quot;OCQ&quot;.
    /// </summary>
    [EnumMember(Value = "OCQ")]
    [IsoId("_Z8nYKNp-Ed-ak6NoX_4Aeg_-1925545676")]
    [Description(@"Transaction is an uncrossed cheque that can be cashed at the bank of origin.")]
    OpenCheque,
    
    /// <summary>
    /// Transaction is a cheque made payable to a named recipient &apos;or order&apos; enabling the creditor to either deposit it in an account or endorse it to a third party, ie, transfer the rights to the cheque by signing it on the reverse.
    /// Encoded/decoded by serializers as &quot;ODC&quot;.
    /// </summary>
    [EnumMember(Value = "ODC")]
    [IsoId("_Z8nYKdp-Ed-ak6NoX_4Aeg_-1925545591")]
    [Description(@"Transaction is a cheque made payable to a named recipient 'or order' enabling the creditor to either deposit it in an account or endorse it to a third party, ie, transfer the rights to the cheque by signing it on the reverse.")]
    OrderCheque,
    
    /// <summary>
    /// Transaction is an instruction from a bank to its correspondent bank to pay the creditor a stated sum of money on presentation of a means of identification.
    /// Encoded/decoded by serializers as &quot;CCQ&quot;.
    /// </summary>
    [EnumMember(Value = "CCQ")]
    [IsoId("_Z8wiENp-Ed-ak6NoX_4Aeg_-1925545202")]
    [Description(@"Transaction is an instruction from a bank to its correspondent bank to pay the creditor a stated sum of money on presentation of a means of identification.")]
    CircularCheque,
    
    /// <summary>
    /// Transaction is a payment resulting from travellers cheques.
    /// Encoded/decoded by serializers as &quot;TCK&quot;.
    /// </summary>
    [EnumMember(Value = "TCK")]
    [IsoId("_Z8wiEdp-Ed-ak6NoX_4Aeg_-1925545088")]
    [Description(@"Transaction is a payment resulting from travellers cheques.")]
    TravellersCheques,
    
    /// <summary>
    /// Transaction is a cheque drawn by a bank on itself or its agent. A person who owes money to another buys the draft from a bank for cash and hands it to the creditor who need have no fear that it might be dishonoured.
    /// Encoded/decoded by serializers as &quot;BKD&quot;.
    /// </summary>
    [EnumMember(Value = "BKD")]
    [IsoId("_Z8wiEtp-Ed-ak6NoX_4Aeg_-1925544738")]
    [Description(@"Transaction is a cheque drawn by a bank on itself or its agent. A person who owes money to another buys the draft from a bank for cash and hands it to the creditor who need have no fear that it might be dishonoured.")]
    BankDraft,
    
    /// <summary>
    /// Transaction is a cash letter. A cash letter is a payment instrument in the form of a covering letter, whereby a financial institution, ie, the remitting bank, requests credit for one or more financial documents under usual reserve, ie, subject to final payment.
    /// Encoded/decoded by serializers as &quot;CLR&quot;.
    /// </summary>
    [EnumMember(Value = "CLR")]
    [IsoId("_Z8wiE9p-Ed-ak6NoX_4Aeg_-1925544643")]
    [Description(@"Transaction is a cash letter. A cash letter is a payment instrument in the form of a covering letter, whereby a financial institution, ie, the remitting bank, requests credit for one or more financial documents under usual reserve, ie, subject to final payment.")]
    CashLetter,
    
    /// <summary>
    /// Transaction is a documentary credit from one banker to another, authorising the payment of a specified sum of money to the person named in the document, based on specified conditions.
    /// Encoded/decoded by serializers as &quot;DCR&quot;.
    /// </summary>
    [EnumMember(Value = "DCR")]
    [IsoId("_Z8wiFNp-Ed-ak6NoX_4Aeg_-1925544530")]
    [Description(@"Transaction is a documentary credit from one banker to another, authorising the payment of a specified sum of money to the person named in the document, based on specified conditions.")]
    DocumentaryCredit,
    
    /// <summary>
    /// Transaction is a written order from a drawer to a drawee to pay a specified sum of money upon demand, or on a specified date, to the drawer or to a third party specified by the drawer. A bill of exchange is also called a draft.
    /// Encoded/decoded by serializers as &quot;BOE&quot;.
    /// </summary>
    [EnumMember(Value = "BOE")]
    [IsoId("_Z8wiFdp-Ed-ak6NoX_4Aeg_-1925544211")]
    [Description(@"Transaction is a written order from a drawer to a drawee to pay a specified sum of money upon demand, or on a specified date, to the drawer or to a third party specified by the drawer. A bill of exchange is also called a draft.")]
    BillOfExchange,
    
    /// <summary>
    /// Transaction is a collection. A collection is the act of sending a cheque, bill of exchange or another financial instrument to the prospective financial institution for payment.
    /// Encoded/decoded by serializers as &quot;COL&quot;.
    /// </summary>
    [EnumMember(Value = "COL")]
    [IsoId("_Z8wiFtp-Ed-ak6NoX_4Aeg_-1925543850")]
    [Description(@"Transaction is a collection. A collection is the act of sending a cheque, bill of exchange or another financial instrument to the prospective financial institution for payment.")]
    Collection,
    
    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CMT&quot;.
    /// </summary>
    [EnumMember(Value = "CMT")]
    [IsoId("_Z8wiF9p-Ed-ak6NoX_4Aeg_-1925543730")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer,
    
    /// <summary>
    /// Transaction relates to a cash management instruction, requesting a sweep of the account of the debtor.
    /// Encoded/decoded by serializers as &quot;CSW&quot;.
    /// </summary>
    [EnumMember(Value = "CSW")]
    [IsoId("_Z8wiGNp-Ed-ak6NoX_4Aeg_-1925543618")]
    [Description(@"Transaction relates to a cash management instruction, requesting a sweep of the account of the debtor.")]
    SweepAccount,
    
    /// <summary>
    /// Transaction is a cash management instruction, requesting to top the account of the debtor above a certain floor amount. The floor amount, if not pre-agreed by the parties involved, may be specified.
    /// Encoded/decoded by serializers as &quot;CTO&quot;.
    /// </summary>
    [EnumMember(Value = "CTO")]
    [IsoId("_Z8wiGdp-Ed-ak6NoX_4Aeg_-1925543246")]
    [Description(@"Transaction is a cash management instruction, requesting to top the account of the debtor above a certain floor amount. The floor amount, if not pre-agreed by the parties involved, may be specified.")]
    TopAccount,
    
    /// <summary>
    /// Transaction is a cash management instruction, requesting to zero balance the account of the debtor.
    /// Encoded/decoded by serializers as &quot;CZB&quot;.
    /// </summary>
    [EnumMember(Value = "CZB")]
    [IsoId("_Z86TENp-Ed-ak6NoX_4Aeg_-1924623154")]
    [Description(@"Transaction is a cash management instruction, requesting to zero balance the account of the debtor.")]
    ZeroBalanceAccount,
    
    /// <summary>
    /// Payment is linked to overnight deposits and the marginal lending facility.
    /// Encoded/decoded by serializers as &quot;STF&quot;.
    /// </summary>
    [EnumMember(Value = "STF")]
    [IsoId("_Z86TEdp-Ed-ak6NoX_4Aeg_-1924623042")]
    [Description(@"Payment is linked to overnight deposits and the marginal lending facility.")]
    StandingFacilities,
    
    /// <summary>
    /// Transaction is a credit transfer to be processed according to the SWIFTPay Service Level.
    /// Encoded/decoded by serializers as &quot;PAY&quot;.
    /// </summary>
    [EnumMember(Value = "PAY")]
    [IsoId("_Z86TEtp-Ed-ak6NoX_4Aeg_-1924622921")]
    [Description(@"Transaction is a credit transfer to be processed according to the SWIFTPay Service Level.")]
    SwiftPayServiceLevelCredit,
    
    /// <summary>
    /// Transaction is a credit transfer to be processed according to the Priority Service Level.
    /// Encoded/decoded by serializers as &quot;PRI&quot;.
    /// </summary>
    [EnumMember(Value = "PRI")]
    [IsoId("_Z86TE9p-Ed-ak6NoX_4Aeg_-1924622591")]
    [Description(@"Transaction is a credit transfer to be processed according to the Priority Service Level.")]
    PriorityServiceLevelCredit,
    
    /// <summary>
    /// Transaction is a credit transfer to be processed according to the Standard Service Level.
    /// Encoded/decoded by serializers as &quot;STD&quot;.
    /// </summary>
    [EnumMember(Value = "STD")]
    [IsoId("_Z86TFNp-Ed-ak6NoX_4Aeg_-1924622223")]
    [Description(@"Transaction is a credit transfer to be processed according to the Standard Service Level.")]
    StandardServiceLevelCredit,
    
    /// <summary>
    /// Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.
    /// Encoded/decoded by serializers as &quot;LIQ&quot;.
    /// </summary>
    [EnumMember(Value = "LIQ")]
    [IsoId("_Z86TFdp-Ed-ak6NoX_4Aeg_-1924622093")]
    [Description(@"Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.")]
    LiquidityTransfer,
    
    /// <summary>
    /// Transaction is a payment made in advance or as an advance.
    /// Encoded/decoded by serializers as &quot;ADV&quot;.
    /// </summary>
    [EnumMember(Value = "ADV")]
    [IsoId("_Z86TFtp-Ed-ak6NoX_4Aeg_-1924621973")]
    [Description(@"Transaction is a payment made in advance or as an advance.")]
    AdvancePayment,
    
    /// <summary>
    /// Transaction reverses a previously incorrectly value dated entry.
    /// Encoded/decoded by serializers as &quot;VDA&quot;.
    /// </summary>
    [EnumMember(Value = "VDA")]
    [IsoId("_Z86TF9p-Ed-ak6NoX_4Aeg_-1924621619")]
    [Description(@"Transaction reverses a previously incorrectly value dated entry.")]
    ValueDateAdjustment,
    
    /// <summary>
    /// Gross cash payment offsetting the amount owed/due for a securities transaction settlement.
    /// Encoded/decoded by serializers as &quot;DPG&quot;.
    /// </summary>
    [EnumMember(Value = "DPG")]
    [IsoId("_Z86TGNp-Ed-ak6NoX_4Aeg_-1924621233")]
    [Description(@"Gross cash payment offsetting the amount owed/due for a securities transaction settlement.")]
    DVPGross,
    
    /// <summary>
    /// Net payment offsetting the cash balance due/owed for a series of securities transactions settlement.
    /// Encoded/decoded by serializers as &quot;DPN&quot;.
    /// </summary>
    [EnumMember(Value = "DPN")]
    [IsoId("_Z86TGdp-Ed-ak6NoX_4Aeg_-1924621121")]
    [Description(@"Net payment offsetting the cash balance due/owed for a series of securities transactions settlement.")]
    DVPNet,
    
    /// <summary>
    /// Transaction is a netting operation.
    /// Encoded/decoded by serializers as &quot;NET&quot;.
    /// </summary>
    [EnumMember(Value = "NET")]
    [IsoId("_Z9EEENp-Ed-ak6NoX_4Aeg_-1924620766")]
    [Description(@"Transaction is a netting operation.")]
    Netting,
    
    /// <summary>
    /// Transaction is a payment that is processed when the pool of liquidity exceeds the minimum value reserved for an express payment in the RTGSPlus system.
    /// Encoded/decoded by serializers as &quot;LMT&quot;.
    /// </summary>
    [EnumMember(Value = "LMT")]
    [IsoId("_Z9EEEdp-Ed-ak6NoX_4Aeg_-1924620636")]
    [Description(@"Transaction is a payment that is processed when the pool of liquidity exceeds the minimum value reserved for an express payment in the RTGSPlus system.")]
    LimitPayment,
    
    /// <summary>
    /// Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.
    /// Encoded/decoded by serializers as &quot;BCK&quot;.
    /// </summary>
    [EnumMember(Value = "BCK")]
    [IsoId("_Z9EEEtp-Ed-ak6NoX_4Aeg_-1924620251")]
    [Description(@"Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.")]
    BackUp,
    
    /// <summary>
    /// Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.
    /// Encoded/decoded by serializers as &quot;EXP&quot;.
    /// </summary>
    [EnumMember(Value = "EXP")]
    [IsoId("_Z9EEE9p-Ed-ak6NoX_4Aeg_-1924620087")]
    [Description(@"Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.")]
    ExpressPayment,
    
    /// <summary>
    /// Payment is made to settle an operation made with the central bank.
    /// Encoded/decoded by serializers as &quot;CTR&quot;.
    /// </summary>
    [EnumMember(Value = "CTR")]
    [IsoId("_Z9EEFNp-Ed-ak6NoX_4Aeg_-1924619740")]
    [Description(@"Payment is made to settle an operation made with the central bank.")]
    CentralBankOperation,
    
    /// <summary>
    /// Payment is linked to CLS activities.
    /// Encoded/decoded by serializers as &quot;CLS&quot;.
    /// </summary>
    [EnumMember(Value = "CLS")]
    [IsoId("_Z9EEFdp-Ed-ak6NoX_4Aeg_-1923699631")]
    [Description(@"Payment is linked to CLS activities.")]
    CLSPayment,
    
    /// <summary>
    /// Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;EUP&quot;.
    /// </summary>
    [EnumMember(Value = "EUP")]
    [IsoId("_Z9EEFtp-Ed-ak6NoX_4Aeg_-1923699494")]
    [Description(@"Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. The origin and destination countries may be one and the same country.")]
    EuroDomesticPayment,
    
    /// <summary>
    /// Transaction is related to the agricultural domain.
    /// Encoded/decoded by serializers as &quot;AGT&quot;.
    /// </summary>
    [EnumMember(Value = "AGT")]
    [IsoId("_Z9EEF9p-Ed-ak6NoX_4Aeg_-1923699139")]
    [Description(@"Transaction is related to the agricultural domain.")]
    AgriculturalTransfer,
    
    /// <summary>
    /// Transaction is a payment(s) made by one spouse to the other after a separation or divorce. An alimony payment may be applied to other family relationships.
    /// Encoded/decoded by serializers as &quot;AMY&quot;.
    /// </summary>
    [EnumMember(Value = "AMY")]
    [IsoId("_Z9EEGNp-Ed-ak6NoX_4Aeg_-1923698641")]
    [Description(@"Transaction is a payment(s) made by one spouse to the other after a separation or divorce. An alimony payment may be applied to other family relationships.")]
    AlimonyPayment,
    
    /// <summary>
    /// Transaction is a payment offsetting the net cash balance owed/due in a retail payment system.
    /// Encoded/decoded by serializers as &quot;BAL&quot;.
    /// </summary>
    [EnumMember(Value = "BAL")]
    [IsoId("_Z9EEGdp-Ed-ak6NoX_4Aeg_-1923698486")]
    [Description(@"Transaction is a payment offsetting the net cash balance owed/due in a retail payment system.")]
    BalanceRetail,
    
    /// <summary>
    /// Net cash payment offsetting the balance due/owed in a retail payment system.
    /// Encoded/decoded by serializers as &quot;BON&quot;.
    /// </summary>
    [EnumMember(Value = "BON")]
    [IsoId("_Z9NOANp-Ed-ak6NoX_4Aeg_-1923698114")]
    [Description(@"Net cash payment offsetting the balance due/owed in a retail payment system.")]
    BonusPayment,
    
    /// <summary>
    /// Transaction is charges levied by a broker.
    /// Encoded/decoded by serializers as &quot;BRF&quot;.
    /// </summary>
    [EnumMember(Value = "BRF")]
    [IsoId("_Z9NOAdp-Ed-ak6NoX_4Aeg_-1923697754")]
    [Description(@"Transaction is charges levied by a broker.")]
    BrokerageFee,
    
    /// <summary>
    /// Transaction is payment into a personal pension scheme for retirement.
    /// Encoded/decoded by serializers as &quot;CBF&quot;.
    /// </summary>
    [EnumMember(Value = "CBF")]
    [IsoId("_Z9NOAtp-Ed-ak6NoX_4Aeg_-1923697615")]
    [Description(@"Transaction is payment into a personal pension scheme for retirement.")]
    CapitalBuilding,
    
    /// <summary>
    /// Transaction is a payment for charity reasons.
    /// Encoded/decoded by serializers as &quot;CHR&quot;.
    /// </summary>
    [EnumMember(Value = "CHR")]
    [IsoId("_Z9NOA9p-Ed-ak6NoX_4Aeg_-1923697478")]
    [Description(@"Transaction is a payment for charity reasons.")]
    CharityPayment,
    
    /// <summary>
    /// Transaction is a payment made to a parent/guardian to help maintain a child.
    /// Encoded/decoded by serializers as &quot;BEC&quot;.
    /// </summary>
    [EnumMember(Value = "BEC")]
    [IsoId("_Z9NOBNp-Ed-ak6NoX_4Aeg_-1923697106")]
    [Description(@"Transaction is a payment made to a parent/guardian to help maintain a child.")]
    ChildBenefit,
    
    /// <summary>
    /// Transaction is settlement of a commercial credit.
    /// Encoded/decoded by serializers as &quot;COC&quot;.
    /// </summary>
    [EnumMember(Value = "COC")]
    [IsoId("_Z9NOBdp-Ed-ak6NoX_4Aeg_-1923696703")]
    [Description(@"Transaction is settlement of a commercial credit.")]
    CommercialCredit,
    
    /// <summary>
    /// Transaction is payment of a fee for executing a transaction.
    /// Encoded/decoded by serializers as &quot;COM&quot;.
    /// </summary>
    [EnumMember(Value = "COM")]
    [IsoId("_Z9NOBtp-Ed-ak6NoX_4Aeg_-1923696548")]
    [Description(@"Transaction is payment of a fee for executing a transaction.")]
    Commission,
    
    /// <summary>
    /// Transaction is a payment of products traded on a commodity exchange.
    /// Encoded/decoded by serializers as &quot;CDT&quot;.
    /// </summary>
    [EnumMember(Value = "CDT")]
    [IsoId("_Z9NOB9p-Ed-ak6NoX_4Aeg_-1923696176")]
    [Description(@"Transaction is a payment of products traded on a commodity exchange.")]
    CommodityTransfer,
    
    /// <summary>
    /// Transaction is apayment of costs.
    /// Encoded/decoded by serializers as &quot;COS&quot;.
    /// </summary>
    [EnumMember(Value = "COS")]
    [IsoId("_Z9NOCNp-Ed-ak6NoX_4Aeg_-1922776032")]
    [Description(@"Transaction is apayment of costs.")]
    Costs,
    
    /// <summary>
    /// Transaction is a payment of copyright.
    /// Encoded/decoded by serializers as &quot;CPY&quot;.
    /// </summary>
    [EnumMember(Value = "CPY")]
    [IsoId("_Z9NOCdp-Ed-ak6NoX_4Aeg_-1922775877")]
    [Description(@"Transaction is a payment of copyright.")]
    Copyright,
    
    /// <summary>
    /// Transaction is apayment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GVT&quot;.
    /// </summary>
    [EnumMember(Value = "GVT")]
    [IsoId("_Z9NOCtp-Ed-ak6NoX_4Aeg_-1922775505")]
    [Description(@"Transaction is apayment to or from a government department.")]
    GovernmentPayment,
    
    /// <summary>
    /// Transaction is a payment of an instalment or to the settlement of a hire-purchase agreement.
    /// Encoded/decoded by serializers as &quot;IHP&quot;.
    /// </summary>
    [EnumMember(Value = "IHP")]
    [IsoId("_Z9W_ANp-Ed-ak6NoX_4Aeg_-1922775083")]
    [Description(@"Transaction is a payment of an instalment or to the settlement of a hire-purchase agreement.")]
    InstalmentHirePurchaseAgreement,
    
    /// <summary>
    /// Transaction is a payment of an insurance premium.
    /// Encoded/decoded by serializers as &quot;INS&quot;.
    /// </summary>
    [EnumMember(Value = "INS")]
    [IsoId("_Z9W_Adp-Ed-ak6NoX_4Aeg_-1922774686")]
    [Description(@"Transaction is a payment of an insurance premium.")]
    InsurancePremium,
    
    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INC&quot;.
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_Z9W_Atp-Ed-ak6NoX_4Aeg_-1922774514")]
    [Description(@"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.")]
    IntraCompanyPayment,
    
    /// <summary>
    /// Transaction is a payment of interest.
    /// Encoded/decoded by serializers as &quot;INT&quot;.
    /// </summary>
    [EnumMember(Value = "INT")]
    [IsoId("_Z9W_A9p-Ed-ak6NoX_4Aeg_-1922774111")]
    [Description(@"Transaction is a payment of interest.")]
    Interest,
    
    /// <summary>
    /// Transaction is a payment of a license fee.
    /// Encoded/decoded by serializers as &quot;LCF&quot;.
    /// </summary>
    [EnumMember(Value = "LCF")]
    [IsoId("_Z9W_BNp-Ed-ak6NoX_4Aeg_-1922773721")]
    [Description(@"Transaction is a payment of a license fee.")]
    LicenseFee,
    
    /// <summary>
    /// Transaction is a purchase or sale of metals.
    /// Encoded/decoded by serializers as &quot;MET&quot;.
    /// </summary>
    [EnumMember(Value = "MET")]
    [IsoId("_Z9W_Bdp-Ed-ak6NoX_4Aeg_-1922773293")]
    [Description(@"Transaction is a purchase or sale of metals.")]
    Metals,
    
    /// <summary>
    /// Transaction is a payment of a pension allowance.
    /// Encoded/decoded by serializers as &quot;PEN&quot;.
    /// </summary>
    [EnumMember(Value = "PEN")]
    [IsoId("_Z9W_Btp-Ed-ak6NoX_4Aeg_-1922773121")]
    [Description(@"Transaction is a payment of a pension allowance.")]
    PensionPayment,
    
    /// <summary>
    /// Transaction is a payment for the purchase and sale of goods.
    /// Encoded/decoded by serializers as &quot;GDS&quot;.
    /// </summary>
    [EnumMember(Value = "GDS")]
    [IsoId("_Z9W_B9p-Ed-ak6NoX_4Aeg_-1922772713")]
    [Description(@"Transaction is a payment for the purchase and sale of goods.")]
    PurchaseSaleOfGoods,
    
    /// <summary>
    /// Transaction is a repayment of funds.
    /// Encoded/decoded by serializers as &quot;REF&quot;.
    /// </summary>
    [EnumMember(Value = "REF")]
    [IsoId("_Z9gI8Np-Ed-ak6NoX_4Aeg_-1915387914")]
    [Description(@"Transaction is a repayment of funds.")]
    Refund,
    
    /// <summary>
    /// Transaction is a payment of rent.
    /// Encoded/decoded by serializers as &quot;REN&quot;.
    /// </summary>
    [EnumMember(Value = "REN")]
    [IsoId("_Z9gI8dp-Ed-ak6NoX_4Aeg_-1915387742")]
    [Description(@"Transaction is a payment of rent.")]
    Rent,
    
    /// <summary>
    /// Transaction is a payment of royalties.
    /// Encoded/decoded by serializers as &quot;ROY&quot;.
    /// </summary>
    [EnumMember(Value = "ROY")]
    [IsoId("_Z9gI8tp-Ed-ak6NoX_4Aeg_-1915387335")]
    [Description(@"Transaction is a payment of royalties.")]
    Royalties,
    
    /// <summary>
    /// Transaction is a payment for the purchase and sale of services.
    /// Encoded/decoded by serializers as &quot;SCV&quot;.
    /// </summary>
    [EnumMember(Value = "SCV")]
    [IsoId("_Z9gI89p-Ed-ak6NoX_4Aeg_-1915386794")]
    [Description(@"Transaction is a payment for the purchase and sale of services.")]
    PurchaseSaleOfServices,
    
    /// <summary>
    /// Transaction is a payment of salaries.
    /// Encoded/decoded by serializers as &quot;SAL&quot;.
    /// </summary>
    [EnumMember(Value = "SAL")]
    [IsoId("_Z9gI9Np-Ed-ak6NoX_4Aeg_-1915386405")]
    [Description(@"Transaction is a payment of salaries.")]
    SalaryPayment,
    
    /// <summary>
    /// Transaction is a social security benefit, a payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSB&quot;.
    /// </summary>
    [EnumMember(Value = "SSB")]
    [IsoId("_Z9gI9dp-Ed-ak6NoX_4Aeg_-1915385959")]
    [Description(@"Transaction is a social security benefit, a payment made by a government to support individuals.")]
    SocialSecurityBenefit,
    
    /// <summary>
    /// Transaction is a standing order. A standing order is an instruction given by a party having explicit authority on the account to debit, ie, either debit account owner or originating party, to a first agent to process cash transfers at specified intervals during an implicit or explicit period of time. It is given once, and is valid for an open or closed period of time.
    /// Encoded/decoded by serializers as &quot;STO&quot;.
    /// </summary>
    [EnumMember(Value = "STO")]
    [IsoId("_Z9gI9tp-Ed-ak6NoX_4Aeg_-1915385551")]
    [Description(@"Transaction is a standing order. A standing order is an instruction given by a party having explicit authority on the account to debit, ie, either debit account owner or originating party, to a first agent to process cash transfers at specified intervals during an implicit or explicit period of time. It is given once, and is valid for an open or closed period of time.")]
    StandingOrder,
    
    /// <summary>
    /// Transaction is a payment of a subscription.
    /// Encoded/decoded by serializers as &quot;SBS&quot;.
    /// </summary>
    [EnumMember(Value = "SBS")]
    [IsoId("_Z9gI99p-Ed-ak6NoX_4Aeg_-1915385106")]
    [Description(@"Transaction is a payment of a subscription.")]
    Subscription,
    
    /// <summary>
    /// Payment is linked to the Treasury State.
    /// Encoded/decoded by serializers as &quot;TRP&quot;.
    /// </summary>
    [EnumMember(Value = "TRP")]
    [IsoId("_Z9gI-Np-Ed-ak6NoX_4Aeg_-1915384908")]
    [Description(@"Payment is linked to the Treasury State.")]
    TreasuryStatePayment,
    
    /// <summary>
    /// Transaction is a payment made to an unemployed/disabled person.
    /// Encoded/decoded by serializers as &quot;BEN&quot;.
    /// </summary>
    [EnumMember(Value = "BEN")]
    [IsoId("_Z9gI-dp-Ed-ak6NoX_4Aeg_-1915384501")]
    [Description(@"Transaction is a payment made to an unemployed/disabled person.")]
    UnemploymentDisabilityBenefit,
    
    /// <summary>
    /// Transaction is apayment of value added tax.
    /// Encoded/decoded by serializers as &quot;VAT&quot;.
    /// </summary>
    [EnumMember(Value = "VAT")]
    [IsoId("_Z9p58Np-Ed-ak6NoX_4Aeg_-1914464332")]
    [Description(@"Transaction is apayment of value added tax.")]
    ValueAddedTaxPayment,
    
    /// <summary>
    /// Transaction is a payment of withholding tax.
    /// Encoded/decoded by serializers as &quot;WHT&quot;.
    /// </summary>
    [EnumMember(Value = "WHT")]
    [IsoId("_Z9p58dp-Ed-ak6NoX_4Aeg_-1914463908")]
    [Description(@"Transaction is a payment of withholding tax.")]
    WithHoldingTax,
    
    /// <summary>
    /// Transaction is a payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAX&quot;.
    /// </summary>
    [EnumMember(Value = "TAX")]
    [IsoId("_Z9p58tp-Ed-ak6NoX_4Aeg_-1914463445")]
    [Description(@"Transaction is a payment of taxes.")]
    TaxPayment,
    
    /// <summary>
    /// Transaction is for an unspecified reason. Miscellaneous is to be used only when no explicit code is available.
    /// Encoded/decoded by serializers as &quot;MSC&quot;.
    /// </summary>
    [EnumMember(Value = "MSC")]
    [IsoId("_Z9p589p-Ed-ak6NoX_4Aeg_-1914463246")]
    [Description(@"Transaction is for an unspecified reason. Miscellaneous is to be used only when no explicit code is available.")]
    Miscellaneous,
    
    /// <summary>
    /// Transaction is linked to an overnight deposit.
    /// Encoded/decoded by serializers as &quot;OND&quot;.
    /// </summary>
    [EnumMember(Value = "OND")]
    [IsoId("_Z9p59Np-Ed-ak6NoX_4Aeg_-335355413")]
    [Description(@"Transaction is linked to an overnight deposit.")]
    OvernightDeposit,
    
    /// <summary>
    /// Transaction is linked to the marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGL&quot;.
    /// </summary>
    [EnumMember(Value = "MGL")]
    [IsoId("_Z9p59dp-Ed-ak6NoX_4Aeg_-335355378")]
    [Description(@"Transaction is linked to the marginal lending facility.")]
    MarginalLending,
    
    /// <summary>
    /// Specifies that a proprietary code must be indicated.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Z9p59tp-Ed-ak6NoX_4Aeg_-335355353")]
    [Description(@"Specifies that a proprietary code must be indicated.")]
    Other,
    
    /// <summary>
    /// Transaction is an initial payment made by one of the counterparties  either to bring a transaction to fair value or for any other reason that may be the cause of an off-market transaction.
    /// Encoded/decoded by serializers as &quot;UFRO&quot;.
    /// </summary>
    [EnumMember(Value = "UFRO")]
    [IsoId("_wNpiAOkAEemV35DUs8L82Q")]
    [Description(@"Transaction is an initial payment made by one of the counterparties  either to bring a transaction to fair value or for any other reason that may be the cause of an off-market transaction.")]
    Upfront,
    
    /// <summary>
    /// Transaction is the final settlement payment made when a transaction is unwound prior to its end date or a payment that may result due to the full termination of derivative transaction(s).
    /// Encoded/decoded by serializers as &quot;UWIN&quot;.
    /// </summary>
    [EnumMember(Value = "UWIN")]
    [IsoId("_w1I_0OkAEemV35DUs8L82Q")]
    [Description(@"Transaction is the final settlement payment made when a transaction is unwound prior to its end date or a payment that may result due to the full termination of derivative transaction(s).")]
    UnWind,
    
    /// <summary>
    /// Transaction is an exchange of notional values for cross-currency swaps.
    /// Encoded/decoded by serializers as &quot;PEXH&quot;.
    /// </summary>
    [EnumMember(Value = "PEXH")]
    [IsoId("_xhJKMOkAEemV35DUs8L82Q")]
    [Description(@"Transaction is an exchange of notional values for cross-currency swaps.")]
    PrincipalExchange,
    
}
