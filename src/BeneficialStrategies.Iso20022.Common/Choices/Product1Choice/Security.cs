// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Product1Choice
{
    /// <summary>
    /// Attributes relating to cleared securities.
    /// </summary>
    [IsoId("_QapNsLVQEeadLcJesEbkTQ")]
    [DisplayName("Security")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Security : Product1Choice_
    #else
    public partial class Security : Product1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Security instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Security( System.String reqIdentification,System.String reqIssuer )
        {
            Identification = reqIdentification;
            Issuer = reqIssuer;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the ISIN of the collateral.
        /// </summary>
        [IsoId("_9iE2ILVYEeadLcJesEbkTQ")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISINOct2015Identifier Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the security issuer.
        /// </summary>
        [IsoId("_DnQrsLVZEeadLcJesEbkTQ")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoLEIIdentifier Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Sector for the security issuer, for example, 0500.
        /// </summary>
        [IsoId("_Hr6M4LVZEeadLcJesEbkTQ")]
        [DisplayName("Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sctr")]
        #endif
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoSNA2008SectorIdentifier? Sector { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Sector { get; init; } 
        #else
        public System.String? Sector { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
