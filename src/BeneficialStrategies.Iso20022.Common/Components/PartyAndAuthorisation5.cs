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
/// Party and related authorisation.
/// </summary>
[IsoId("_LH4RU249EeiU9cctagi5ow")]
[DisplayName("Party And Authorisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyAndAuthorisation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyAndAuthorisation5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyAndAuthorisation5( PartyOrGroup2Choice_ reqPartyOrGroup,Authorisation2 reqAuthorisation )
    {
        PartyOrGroup = reqPartyOrGroup;
        Authorisation = reqAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_LUGvYW49EeiU9cctagi5ow")]
    [DisplayName("Modification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCd")]
    #endif
    [IsoXmlTag("ModCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? ModificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? ModificationCode { get; init; } 
    #else
    public Modification1Code? ModificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a party or a group of parties.
    /// </summary>
    [IsoId("_LUGvY249EeiU9cctagi5ow")]
    [DisplayName("Party Or Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyOrGrp")]
    #endif
    [IsoXmlTag("PtyOrGrp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyOrGroup2Choice_ PartyOrGroup { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyOrGroup2Choice_ PartyOrGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyOrGroup2Choice_ PartyOrGroup { get; init; } 
    #else
    public PartyOrGroup2Choice_ PartyOrGroup { get; set; } 
    #endif
    
    /// <summary>
    /// Order in which the mandate holder has to sign.
    /// </summary>
    [IsoId("_LUGvZW49EeiU9cctagi5ow")]
    [DisplayName("Signature Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrOrdr")]
    #endif
    [IsoXmlTag("SgntrOrdr")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SignatureOrder { get; init; } 
    #else
    public System.String? SignatureOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Authorisation granted to a mandate holder.
    /// </summary>
    [IsoId("_LUGvZ249EeiU9cctagi5ow")]
    [DisplayName("Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authstn")]
    #endif
    [IsoXmlTag("Authstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Authorisation2 Authorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Authorisation2 Authorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Authorisation2 Authorisation { get; init; } 
    #else
    public Authorisation2 Authorisation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
