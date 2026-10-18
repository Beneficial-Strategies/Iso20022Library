// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="INumberOfTransactionsPerStatus1"/>
[IsoId("_RFBsa9p-Ed-ak6NoX_4Aeg_187558079")]
[DisplayName("Number Of Transactions Per Status")]
public partial record NumberOfTransactionsPerStatus1
{
    /// <inheritdoc cref="INumberOfTransactionsPerStatus1.DetailedNumberOfTransactions"/>
    [IsoId("_RFBsbNp-Ed-ak6NoX_4Aeg_1091683583")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; }

    /// <inheritdoc cref="INumberOfTransactionsPerStatus1.DetailedStatus"/>
    [IsoId("_RFBsbdp-Ed-ak6NoX_4Aeg_1140631688")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required TransactionIndividualStatus1Code DetailedStatus { get; init; }

    /// <inheritdoc cref="INumberOfTransactionsPerStatus1.DetailedControlSum"/>
    [IsoId("_RFLdYNp-Ed-ak6NoX_4Aeg_-1896383471")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DetailedControlSum { get; init; }
}
