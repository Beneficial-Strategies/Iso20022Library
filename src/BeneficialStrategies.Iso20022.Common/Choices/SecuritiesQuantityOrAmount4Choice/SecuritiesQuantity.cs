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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount4Choice
{
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_ICF6EbXQEeiTob_PrFFUxA")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesQuantity : SecuritiesQuantityOrAmount4Choice_
    #else
    public partial class SecuritiesQuantity : SecuritiesQuantityOrAmount4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesQuantity( Quantity20Choice_ reqInstructedQuantity )
        {
            InstructedQuantity = reqInstructedQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
        /// </summary>
        [IsoId("_IVbs0bXQEeiTob_PrFFUxA")]
        [DisplayName("Conditional Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CondlQty")]
        #endif
        [IsoXmlTag("CondlQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; } 
        #else
        public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of securities to which this instruction applies.
        /// </summary>
        [IsoId("_IVbs2bXQEeiTob_PrFFUxA")]
        [DisplayName("Instructed Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstdQty")]
        #endif
        [IsoXmlTag("InstdQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Quantity20Choice_ InstructedQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Quantity20Choice_ InstructedQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Quantity20Choice_ InstructedQuantity { get; init; } 
        #else
        public Quantity20Choice_ InstructedQuantity { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
        /// </summary>
        [IsoId("_T38GsLXQEeiTob_PrFFUxA")]
        [DisplayName("Additional Round Up Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRndUpQty")]
        #endif
        [IsoXmlTag("AddtlRndUpQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentQuantity1Choice_? AdditionalRoundUpQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity1Choice_? AdditionalRoundUpQuantity { get; init; } 
        #else
        public FinancialInstrumentQuantity1Choice_? AdditionalRoundUpQuantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
