// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of account owner and identifiers.
/// </summary>
[IsoId("_UHyvQCDvEeav65mEytrgaA")]
[DisplayName("Account Owner And Identification List")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountOwnerAndIdentificationList1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// List of the identifier pairs.
    /// </summary>
    [IsoId("_qhLMECDvEeav65mEytrgaA")]
    [DisplayName("List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="List")]
    #endif
    [IsoXmlTag("List")]
    public ValueList<AccountOwnerAndIdentification1> List { get; init; } = new ValueList<AccountOwnerAndIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _qhLMECDvEeav65mEytrgaA
    
    
    #nullable disable
    
}
