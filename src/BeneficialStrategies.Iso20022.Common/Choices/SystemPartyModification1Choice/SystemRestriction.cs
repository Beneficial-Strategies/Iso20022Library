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
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification1Choice
{
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_ko4LtO5NEeCisYr99QEiWA_479259018")]
    [DisplayName("System Restriction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SystemRestriction : SystemPartyModification1Choice_
    #else
    public partial class SystemRestriction : SystemPartyModification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SystemRestriction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SystemRestriction( System.DateTime reqValidFrom,System.String reqType )
        {
            ValidFrom = reqValidFrom;
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the date from which the restriction is valid.
        /// </summary>
        [IsoId("_kpU3oe5NEeCisYr99QEiWA_534617393")]
        [DisplayName("Valid From")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldFr")]
        #endif
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ValidFrom { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime ValidFrom { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ValidFrom { get; init; } 
        #else
        public System.DateTime ValidFrom { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the date until which the restriction is valid.
        /// </summary>
        [IsoId("_kpU3ou5NEeCisYr99QEiWA_1295382546")]
        [DisplayName("Valid To")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldTo")]
        #endif
        [IsoXmlTag("VldTo")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? ValidTo { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? ValidTo { get; init; } 
        #else
        public System.DateTime? ValidTo { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the identification of a restriction.
        /// </summary>
        [IsoId("_kpU3o-5NEeCisYr99QEiWA_1881329572")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Type { get; init; } 
        #else
        public System.String Type { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
