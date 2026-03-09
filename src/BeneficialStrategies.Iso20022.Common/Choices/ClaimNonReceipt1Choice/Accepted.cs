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
namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt1Choice
{
    /// <summary>
    /// Claim non-receipt is accepted and processed by the agent.
    /// </summary>
    [IsoId("_vzbp0IjYEeeDW7_wB-eK_g")]
    [DisplayName("Accepted")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Accepted : ClaimNonReceipt1Choice_
    #else
    public partial class Accepted : ClaimNonReceipt1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Accepted instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Accepted( System.DateOnly reqDateProcessed,BranchAndFinancialInstitutionIdentification5 reqOriginalNextAgent )
        {
            DateProcessed = reqDateProcessed;
            OriginalNextAgent = reqOriginalNextAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the date the original payment instruction was processed.
        /// </summary>
        [IsoId("_hPoCUItuEee-OJ-wXSj3YQ")]
        [DisplayName("Date Processed")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtPrcd")]
        #endif
        [IsoXmlTag("DtPrcd")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate DateProcessed { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly DateProcessed { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly DateProcessed { get; init; } 
        #else
        public System.DateOnly DateProcessed { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the next party the original payment instruction was sent to.
        /// </summary>
        [IsoId("_jfyHEItuEee-OJ-wXSj3YQ")]
        [DisplayName("Original Next Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlNxtAgt")]
        #endif
        [IsoXmlTag("OrgnlNxtAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
