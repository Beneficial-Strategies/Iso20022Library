// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_RRjFctp-Ed-ak6NoX_4Aeg_-1364149663")]
[DisplayName("Modification Scope")]
public partial record ModificationScope10
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRjFc9p-Ed-ak6NoX_4Aeg_-1364149628")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Identification of information which is part of a service level agreement.
    /// </summary>
    [IsoId("_RRjFdNp-Ed-ak6NoX_4Aeg_1787843945")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    public required DocumentToSend1 ServiceLevelAgreement { get; init; } 
    
    
    #nullable disable
    
}
