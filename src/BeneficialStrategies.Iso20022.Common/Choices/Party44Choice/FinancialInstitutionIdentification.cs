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
namespace BeneficialStrategies.Iso20022.Choices.Party44Choice
{
    /// <summary>
    /// Identification of a financial institution.
    /// </summary>
    [IsoId("_98TyY249EeiU9cctagi5ow")]
    [DisplayName("Financial Institution Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FinancialInstitutionIdentification : Party44Choice_
    #else
    public partial class FinancialInstitutionIdentification : Party44Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FinancialInstitutionIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FinancialInstitutionIdentification( FinancialInstitutionIdentification18 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstnId")]
        #endif
        [IsoXmlTag("FinInstnId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstitutionIdentification18 Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstitutionIdentification18 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification18 Value { get; init; } 
        #else
        public FinancialInstitutionIdentification18 Value { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_8xXCM249EeiU9cctagi5ow")]
        [DisplayName("Branch Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BrnchId")]
        #endif
        [IsoXmlTag("BrnchId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchData3? BranchIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchData3? BranchIdentification { get; init; } 
        #else
        public BranchData3? BranchIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
