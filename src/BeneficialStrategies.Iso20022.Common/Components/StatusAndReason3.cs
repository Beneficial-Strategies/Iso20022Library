// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of a transaction.
/// </summary>
[IsoId("_UVMcq9p-Ed-ak6NoX_4Aeg_107215174")]
[DisplayName("Status And Reason")]
public record StatusAndReason3
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_UVWNoNp-Ed-ak6NoX_4Aeg_107215588")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus6Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_UVWNodp-Ed-ak6NoX_4Aeg_107216554")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus2Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_UVWNotp-Ed-ak6NoX_4Aeg_107215666")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus2Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_UVWNo9p-Ed-ak6NoX_4Aeg_107215992")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus2Choice_? SettlementStatus { get; init; }
}
