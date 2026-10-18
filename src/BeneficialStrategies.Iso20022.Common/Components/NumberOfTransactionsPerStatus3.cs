// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="INumberOfTransactionsPerStatus3"/>
[IsoId("_Rq4LcNp-Ed-ak6NoX_4Aeg_1400369330")]
[DisplayName("Number Of Transactions Per Status")]
public partial record NumberOfTransactionsPerStatus3
{
    /// <inheritdoc cref="INumberOfTransactionsPerStatus3.DetailedNumberOfTransactions"/>
    [IsoId("_Rq4Lcdp-Ed-ak6NoX_4Aeg_1400369332")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; }

    /// <inheritdoc cref="INumberOfTransactionsPerStatus3.DetailedStatus"/>
    [IsoId("_Rq4Lctp-Ed-ak6NoX_4Aeg_1400369360")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required TransactionIndividualStatus3Code DetailedStatus { get; init; }

    /// <inheritdoc cref="INumberOfTransactionsPerStatus3.DetailedControlSum"/>
    [IsoId("_Rq4Lc9p-Ed-ak6NoX_4Aeg_1400369391")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DetailedControlSum { get; init; }
}
