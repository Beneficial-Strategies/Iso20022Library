// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the quantity, account and other related information involved in a transaction.
/// </summary>
[IsoId("_Ucy5gtp-Ed-ak6NoX_4Aeg_-1394559879")]
[DisplayName("Quantity And Account")]
public record QuantityAndAccount2
{
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_Ucy5g9p-Ed-ak6NoX_4Aeg_-1394559446")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required Quantity6Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_Ucy5hNp-Ed-ak6NoX_4Aeg_1004910797")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_Ucy5hdp-Ed-ak6NoX_4Aeg_1002140110")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Amount of money previously settled.
    /// </summary>
    [IsoId("_Uc8qcNp-Ed-ak6NoX_4Aeg_1846191786")]
    [DisplayName("Previously Settled Amount")]
    [IsoXmlTag("PrevslySttldAmt")]
    public AmountAndDirection7? PreviouslySettledAmount { get; init; }

    /// <summary>
    /// Amount of money remaining to be settled.
    /// </summary>
    [IsoId("_Uc8qcdp-Ed-ak6NoX_4Aeg_1806480886")]
    [DisplayName("Remaining To Be Settled Amount")]
    [IsoXmlTag("RmngToBeSttldAmt")]
    public AmountAndDirection7? RemainingToBeSettledAmount { get; init; }

    /// <summary>
    /// Denomination of the security to be received or delivered.
    /// </summary>
    [IsoId("_Uc8qctp-Ed-ak6NoX_4Aeg_-1394559844")]
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? DenominationChoice { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Uc8qc9p-Ed-ak6NoX_4Aeg_-1394559741")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Uc8qdNp-Ed-ak6NoX_4Aeg_-1953898663")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Uc8qddp-Ed-ak6NoX_4Aeg_-1394559862")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_Uc8qdtp-Ed-ak6NoX_4Aeg_-1394559818")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown3> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Uc8qd9p-Ed-ak6NoX_4Aeg_-1679945523")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; }
}
