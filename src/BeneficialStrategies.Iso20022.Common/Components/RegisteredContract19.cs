// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Registered Contract19.
/// </summary>
[IsoId("_6qdpsTEyEe6g-ffJsqGiSA")]
[DisplayName("Registered Contract19")]
public record RegisteredContract19
{
    /// <summary>
    /// Attachment.
    /// </summary>
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Cession.
    /// </summary>
    [DisplayName("Cession")]
    [IsoXmlTag("Cssn")]
    public ContractCessionData2? Cession { get; init; }

    /// <summary>
    /// Closure Reason.
    /// </summary>
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; }

    /// <summary>
    /// Original Registered Contract.
    /// </summary>
    [DisplayName("Original Registered Contract")]
    [IsoXmlTag("OrgnlRegdCtrct")]
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; }

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; }

    /// <summary>
    /// Registered Contract Closure Identification.
    /// </summary>
    [DisplayName("Registered Contract Closure Identification")]
    [IsoXmlTag("RegdCtrctClsrId")]
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; }

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; }

    /// <summary>
    /// Reporting Party.
    /// </summary>
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty6 ReportingParty { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
