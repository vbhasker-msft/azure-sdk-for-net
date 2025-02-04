// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Transformation for data flow sink.
    /// </summary>
    public partial class DataFlowSink : Transformation
    {
        /// <summary>
        /// Initializes a new instance of the DataFlowSink class.
        /// </summary>
        public DataFlowSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataFlowSink class.
        /// </summary>
        /// <param name="name">Transformation name.</param>
        /// <param name="description">Transformation description.</param>
        /// <param name="flowlet">Flowlet Reference</param>
        /// <param name="dataset">Dataset reference.</param>
        /// <param name="linkedService">Linked service reference.</param>
        /// <param name="schemaLinkedService">Schema linked service
        /// reference.</param>
        public DataFlowSink(string name, string description = default(string), DataFlowReference flowlet = default(DataFlowReference), DatasetReference dataset = default(DatasetReference), LinkedServiceReference linkedService = default(LinkedServiceReference), LinkedServiceReference schemaLinkedService = default(LinkedServiceReference))
            : base(name, description, flowlet)
        {
            Dataset = dataset;
            LinkedService = linkedService;
            SchemaLinkedService = schemaLinkedService;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Gets or sets linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "linkedService")]
        public LinkedServiceReference LinkedService { get; set; }

        /// <summary>
        /// Gets or sets schema linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "schemaLinkedService")]
        public LinkedServiceReference SchemaLinkedService { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset != null)
            {
                Dataset.Validate();
            }
            if (LinkedService != null)
            {
                LinkedService.Validate();
            }
            if (SchemaLinkedService != null)
            {
                SchemaLinkedService.Validate();
            }
        }
    }
}
