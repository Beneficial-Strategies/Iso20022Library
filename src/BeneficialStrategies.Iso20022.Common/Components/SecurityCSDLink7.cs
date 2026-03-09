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
/// Defines how the CSD is linked to the security.
/// </summary>
[IsoId("_x-0e8Wc-EemvNLufWGIVOQ")]
[DisplayName("Security CSD Link")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityCSDLink7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityCSDLink7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityCSDLink7( DateAndDateTime2Choice_ reqValidFrom )
    {
        ValidFrom = reqValidFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the date since when the CSD is linked to the security.
    /// </summary>
    [IsoId("_yJ6UoWc-EemvNLufWGIVOQ")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ ValidFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ ValidFrom { get; init; } 
    #else
    public DateAndDateTime2Choice_ ValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the date until when the CSD is linked to the security.
    /// </summary>
    [IsoId("_yJ6Uo2c-EemvNLufWGIVOQ")]
    [DisplayName("Valid To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldTo")]
    #endif
    [IsoXmlTag("VldTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValidTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValidTo { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValidTo { get; set; } 
    #endif
    
    /// <summary>
    /// Specify if the involved CSD (issuer/technical issuer/investor) is also the maintainer of related reference data.
    /// </summary>
    [IsoId("_yJ6UpWc-EemvNLufWGIVOQ")]
    [DisplayName("Security Maintenance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyMntnc")]
    #endif
    [IsoXmlTag("SctyMntnc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SecurityMaintenance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityMaintenance { get; init; } 
    #else
    public System.String? SecurityMaintenance { get; set; } 
    #endif
    
    /// <summary>
    /// CSD Issuer of a security.
    /// </summary>
    [IsoId("_yJ6Up2c-EemvNLufWGIVOQ")]
    [DisplayName("Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCSD")]
    #endif
    [IsoXmlTag("IssrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? IssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? IssuerCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? IssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// CSD Investor of a security.
    /// </summary>
    [IsoId("_yJ6UqWc-EemvNLufWGIVOQ")]
    [DisplayName("Investor CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrCSD")]
    #endif
    [IsoXmlTag("InvstrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? InvestorCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? InvestorCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? InvestorCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Technical issuer of a security.
    /// </summary>
    [IsoId("_yJ6Uq2c-EemvNLufWGIVOQ")]
    [DisplayName("Technical Issuer CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechIssrCSD")]
    #endif
    [IsoXmlTag("TechIssrCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 
    #else
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_yJ6UrWc-EemvNLufWGIVOQ")]
    [DisplayName("Issuance Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncAcct")]
    #endif
    [IsoXmlTag("IssncAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IssuanceAccount2? IssuanceAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuanceAccount2? IssuanceAccount { get; init; } 
    #else
    public IssuanceAccount2? IssuanceAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
