// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the participants with the highest volume and value ranking for settlement fails.
/// </summary>
[IsoId("_VEBnQI0UEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Participant Range")]
public partial record SettlementFailsParticipantRange1
{
    #nullable enable
    
    /// <summary>
    /// Participant with the highest volume of settlement fails.
    /// </summary>
    [IsoId("_acReUI0UEemUAO64Q252gQ")]
    [DisplayName("Highest In Volume")]
    [IsoXmlTag("HghstInVol")]
    public ValueList<SettlementFailsParticipant1> HighestInVolume { get; init; } = new ValueList<SettlementFailsParticipant1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _acReUI0UEemUAO64Q252gQ
    
    /// <summary>
    /// Participant with the highest value of settlement fails.
    /// </summary>
    [IsoId("_cDRRUI0UEemUAO64Q252gQ")]
    [DisplayName("Highest In Value")]
    [IsoXmlTag("HghstInVal")]
    public ValueList<SettlementFailsParticipant1> HighestInValue { get; init; } = new ValueList<SettlementFailsParticipant1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _cDRRUI0UEemUAO64Q252gQ
    
    
    #nullable disable
    
}
