﻿using PipServices3.Commons.Refer;
using PipServices3.Components.Build;
using PipServices3.Rpc.Services;

namespace PipServices3.Rpc.Build
{
    /// <summary>
    /// Creates RPC components by their descriptors.
    /// </summary>
    /// See <a href="https://rawgit.com/pip-services3-dotnet/pip-services3-components-dotnet/master/doc/api/class_pip_services_1_1_components_1_1_build_1_1_factory.html">Factory</a>, 
    /// <a href="https://rawgit.com/pip-services3-dotnet/pip-services3-rpc-dotnet/master/doc/api/class_pip_services_1_1_rpc_1_1_services_1_1_http_endpoint.html">HttpEndpoint</a>, 
    /// <a href="https://rawgit.com/pip-services3-dotnet/pip-services3-rpc-dotnet/master/doc/api/class_pip_services_1_1_rpc_1_1_services_1_1_status_rest_service.html">StatusRestService</a>, 
    /// <a href="https://rawgit.com/pip-services3-dotnet/pip-services3-rpc-dotnet/master/doc/api/class_pip_services_1_1_rpc_1_1_services_1_1_heartbeat_rest_service.html">HeartbeatRestService</a>
    public class DefaultRpcFactory : Factory
    {
        public static Descriptor Descriptor = new Descriptor("pip-services3", "factory", "rpc", "default", "1.0");
        public static Descriptor HttpEndpointDescriptor = new Descriptor("pip-services3", "endpoint", "http", "*", "1.0");
        public static Descriptor StatusServiceDescriptor = new Descriptor("pip-services3", "status-service", "http", "*", "1.0");
        public static Descriptor HeartbeatServiceDescriptor = new Descriptor("pip-services3", "heartbeat-service", "http", "*", "1.0");

        /// <summary>
        /// Create a new instance of the factory.
        /// </summary>
        public DefaultRpcFactory()
        {
            RegisterAsType(HttpEndpointDescriptor, typeof(HttpEndpoint));
            RegisterAsType(StatusServiceDescriptor, typeof(StatusRestService));
            RegisterAsType(HeartbeatServiceDescriptor, typeof(HeartbeatRestService));
        }
    }
}
