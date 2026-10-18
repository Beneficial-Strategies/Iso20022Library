// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalGroupHeader1"/>
[IsoId("_sniXsFkyEeGeoaLUQk__nA_1278270511")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader1
{
    /// <inheritdoc cref="IOriginalGroupHeader1.OriginalMessageIdentification"/>
    [IsoId("_sniXsVkyEeGeoaLUQk__nA_1164431445")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader1.OriginalMessageNameIdentification"/>
    [IsoId("_snrhoFkyEeGeoaLUQk__nA_281198158")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader1.OriginalCreationDateTime"/>
    [IsoId("_snrhoVkyEeGeoaLUQk__nA_167359092")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader1.OriginalNumberOfTransactions"/>
    [IsoId("_snrholkyEeGeoaLUQk__nA_-829713261")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader1.OriginalControlSum"/>
    [IsoId("_sn1SoFkyEeGeoaLUQk__nA_-1826785614")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader1.GroupStatus"/>
    [IsoId("_sn_DoFkyEeGeoaLUQk__nA_-1057875524")]
    [DisplayName("Group Status")]
    [IsoXmlTag("GrpSts")]
    public TransactionGroupStatus3Code? GroupStatus { get; init; }

    /// <inheritdoc cref="IOriginalGroupHeader1.StatusReasonInformation"/>
    [IsoId("_sn_DoVkyEeGeoaLUQk__nA_-2054947877")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalGroupHeader1.NumberOfTransactionsPerStatus"/>
    [IsoId("_soINkFkyEeGeoaLUQk__nA_1242947066")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];
}
