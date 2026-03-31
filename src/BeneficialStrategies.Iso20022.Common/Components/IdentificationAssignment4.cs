// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification Assignment4.
/// </summary>
[IsoId("_0_d1wTEyEe6g-ffJsqGiSA")]
[DisplayName("Identification Assignment4")]
public record IdentificationAssignment4
{
    /// <summary>
    /// Assignee.
    /// </summary>
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party50Choice_ Assignee { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party50Choice_ Assigner { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Creator.
    /// </summary>
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public Party50Choice_? Creator { get; init; }

    /// <summary>
    /// First Agent.
    /// </summary>
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public BranchAndFinancialInstitutionIdentification8? FirstAgent { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }
}
