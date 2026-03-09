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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, through a combimation of globally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_TFnrItp-Ed-ak6NoX_4Aeg_1781480692")]
    [DisplayName("Combined Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CombinedIdentification : FinancialInstitutionIdentification5Choice_
    #else
    public partial class CombinedIdentification : FinancialInstitutionIdentification5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoId("_TFehMdp-Ed-ak6NoX_4Aeg_696920663")]
        [DisplayName("BIC")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BIC")]
        #endif
        [IsoXmlTag("BIC")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoBICIdentifier? BIC { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BIC { get; init; } 
        #else
        public System.String? BIC { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier of a clearing system member, as assigned by the system or system administrator.
        /// </summary>
        [IsoId("_TFehMtp-Ed-ak6NoX_4Aeg_696921670")]
        [DisplayName("Clearing System Member Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSysMmbId")]
        #endif
        [IsoXmlTag("ClrSysMmbId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ClearingSystemMemberIdentification3Choice_? ClearingSystemMemberIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ClearingSystemMemberIdentification3Choice_? ClearingSystemMemberIdentification { get; init; } 
        #else
        public ClearingSystemMemberIdentification3Choice_? ClearingSystemMemberIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_TFehM9p-Ed-ak6NoX_4Aeg_696922156")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax70Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_TFehNNp-Ed-ak6NoX_4Aeg_696923981")]
        [DisplayName("Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstlAdr")]
        #endif
        [IsoXmlTag("PstlAdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PostalAddress1? PostalAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress1? PostalAddress { get; init; } 
        #else
        public PostalAddress1? PostalAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
        /// </summary>
        [IsoId("_TFehNdp-Ed-ak6NoX_4Aeg_-1274464914")]
        [DisplayName("Proprietary Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryId")]
        #endif
        [IsoXmlTag("PrtryId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericIdentification3? ProprietaryIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification3? ProprietaryIdentification { get; init; } 
        #else
        public GenericIdentification3? ProprietaryIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
