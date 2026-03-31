// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_70efBVhLEeih3fUfzR38Ig")]
[DisplayName("Party Reference Data Change")]
public record PartyReferenceDataChange2
{
    /// <summary>
    /// Identifies the party for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_7_fcMVhLEeih3fUfzR38Ig")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification8 PartyIdentification { get; init; }

    /// <summary>
    /// Provides the party data record for which details of the change are provided.
    /// </summary>
    [IsoId("_E_5woIp8EeiEt5E1WBt_2Q")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<UpdateLogPartyRecord1Choice_> Record { get; init; } = [];

    // ID for the above is _E_5woIp8EeiEt5E1WBt_2Q

    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_7_fcOVhLEeih3fUfzR38Ig")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; }
}
