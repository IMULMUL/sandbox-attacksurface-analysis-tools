//  Copyright 2021 Google LLC. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;

namespace NtApiDotNet.Net.Firewall
{
    static class FirewallLayerGuids
    {
        // c86fd1bf-21cd-497e-a0bb-17425c885c58
        public static Guid FWPM_LAYER_INBOUND_IPPACKET_V4 = new Guid(0xc86fd1bf, 0x21cd, 0x497e, 0xa0, 0xbb, 0x17, 0x42, 0x5c, 0x88, 0x5c, 0x58);
        // b5a230d0-a8c0-44f2-916e-991b53ded1f7
        public static Guid FWPM_LAYER_INBOUND_IPPACKET_V4_DISCARD = new Guid(0xb5a230d0, 0xa8c0, 0x44f2, 0x91, 0x6e, 0x99, 0x1b, 0x53, 0xde, 0xd1, 0xf7);
        // f52032cb-991c-46e7-971d-2601459a91ca
        public static Guid FWPM_LAYER_INBOUND_IPPACKET_V6 = new Guid(0xf52032cb, 0x991c, 0x46e7, 0x97, 0x1d, 0x26, 0x01, 0x45, 0x9a, 0x91, 0xca);
        // bb24c279-93b4-47a2-83ad-ae1698b50885
        public static Guid FWPM_LAYER_INBOUND_IPPACKET_V6_DISCARD = new Guid(0xbb24c279, 0x93b4, 0x47a2, 0x83, 0xad, 0xae, 0x16, 0x98, 0xb5, 0x08, 0x85);
        // 1e5c9fae-8a84-4135-a331-950b54229ecd
        public static Guid FWPM_LAYER_OUTBOUND_IPPACKET_V4 = new Guid(0x1e5c9fae, 0x8a84, 0x4135, 0xa3, 0x31, 0x95, 0x0b, 0x54, 0x22, 0x9e, 0xcd);
        // 08e4bcb5-b647-48f3-953c-e5ddbd03937e
        public static Guid FWPM_LAYER_OUTBOUND_IPPACKET_V4_DISCARD = new Guid(0x08e4bcb5, 0xb647, 0x48f3, 0x95, 0x3c, 0xe5, 0xdd, 0xbd, 0x03, 0x93, 0x7e);
        // a3b3ab6b-3564-488c-9117-f34e82142763
        public static Guid FWPM_LAYER_OUTBOUND_IPPACKET_V6 = new Guid(0xa3b3ab6b, 0x3564, 0x488c, 0x91, 0x17, 0xf3, 0x4e, 0x82, 0x14, 0x27, 0x63);
        // 9513d7c4-a934-49dc-91a7-6ccb80cc02e3
        public static Guid FWPM_LAYER_OUTBOUND_IPPACKET_V6_DISCARD = new Guid(0x9513d7c4, 0xa934, 0x49dc, 0x91, 0xa7, 0x6c, 0xcb, 0x80, 0xcc, 0x02, 0xe3);
        // a82acc24-4ee1-4ee1-b465-fd1d25cb10a4
        public static Guid FWPM_LAYER_IPFORWARD_V4 = new Guid(0xa82acc24, 0x4ee1, 0x4ee1, 0xb4, 0x65, 0xfd, 0x1d, 0x25, 0xcb, 0x10, 0xa4);
        // 9e9ea773-2fae-4210-8f17-34129ef369eb
        public static Guid FWPM_LAYER_IPFORWARD_V4_DISCARD = new Guid(0x9e9ea773, 0x2fae, 0x4210, 0x8f, 0x17, 0x34, 0x12, 0x9e, 0xf3, 0x69, 0xeb);
        // 7b964818-19c7-493a-b71f-832c3684d28c
        public static Guid FWPM_LAYER_IPFORWARD_V6 = new Guid(0x7b964818, 0x19c7, 0x493a, 0xb7, 0x1f, 0x83, 0x2c, 0x36, 0x84, 0xd2, 0x8c);
        // 31524a5d-1dfe-472f-bb93-518ee945d8a2
        public static Guid FWPM_LAYER_IPFORWARD_V6_DISCARD = new Guid(0x31524a5d, 0x1dfe, 0x472f, 0xbb, 0x93, 0x51, 0x8e, 0xe9, 0x45, 0xd8, 0xa2);
        // 5926dfc8-e3cf-4426-a283-dc393f5d0f9d
        public static Guid FWPM_LAYER_INBOUND_TRANSPORT_V4 = new Guid(0x5926dfc8, 0xe3cf, 0x4426, 0xa2, 0x83, 0xdc, 0x39, 0x3f, 0x5d, 0x0f, 0x9d);
        // ac4a9833-f69d-4648-b261-6dc84835ef39
        public static Guid FWPM_LAYER_INBOUND_TRANSPORT_V4_DISCARD = new Guid(0xac4a9833, 0xf69d, 0x4648, 0xb2, 0x61, 0x6d, 0xc8, 0x48, 0x35, 0xef, 0x39);
        // 634a869f-fc23-4b90-b0c1-bf620a36ae6f
        public static Guid FWPM_LAYER_INBOUND_TRANSPORT_V6 = new Guid(0x634a869f, 0xfc23, 0x4b90, 0xb0, 0xc1, 0xbf, 0x62, 0x0a, 0x36, 0xae, 0x6f);
        // 2a6ff955-3b2b-49d2-9848-ad9d72dcaab7
        public static Guid FWPM_LAYER_INBOUND_TRANSPORT_V6_DISCARD = new Guid(0x2a6ff955, 0x3b2b, 0x49d2, 0x98, 0x48, 0xad, 0x9d, 0x72, 0xdc, 0xaa, 0xb7);
        // 09e61aea-d214-46e2-9b21-b26b0b2f28c8
        public static Guid FWPM_LAYER_OUTBOUND_TRANSPORT_V4 = new Guid(0x09e61aea, 0xd214, 0x46e2, 0x9b, 0x21, 0xb2, 0x6b, 0x0b, 0x2f, 0x28, 0xc8);
        // c5f10551-bdb0-43d7-a313-50e211f4d68a
        public static Guid FWPM_LAYER_OUTBOUND_TRANSPORT_V4_DISCARD = new Guid(0xc5f10551, 0xbdb0, 0x43d7, 0xa3, 0x13, 0x50, 0xe2, 0x11, 0xf4, 0xd6, 0x8a);
        // e1735bde-013f-4655-b351-a49e15762df0
        public static Guid FWPM_LAYER_OUTBOUND_TRANSPORT_V6 = new Guid(0xe1735bde, 0x013f, 0x4655, 0xb3, 0x51, 0xa4, 0x9e, 0x15, 0x76, 0x2d, 0xf0);
        // f433df69-ccbd-482e-b9b2-57165658c3b3
        public static Guid FWPM_LAYER_OUTBOUND_TRANSPORT_V6_DISCARD = new Guid(0xf433df69, 0xccbd, 0x482e, 0xb9, 0xb2, 0x57, 0x16, 0x56, 0x58, 0xc3, 0xb3);
        // 3b89653c-c170-49e4-b1cd-e0eeeee19a3e
        public static Guid FWPM_LAYER_STREAM_V4 = new Guid(0x3b89653c, 0xc170, 0x49e4, 0xb1, 0xcd, 0xe0, 0xee, 0xee, 0xe1, 0x9a, 0x3e);
        // 25c4c2c2-25ff-4352-82f9-c54a4a4726dc
        public static Guid FWPM_LAYER_STREAM_V4_DISCARD = new Guid(0x25c4c2c2, 0x25ff, 0x4352, 0x82, 0xf9, 0xc5, 0x4a, 0x4a, 0x47, 0x26, 0xdc);
        // 47c9137a-7ec4-46b3-b6e4-48e926b1eda4
        public static Guid FWPM_LAYER_STREAM_V6 = new Guid(0x47c9137a, 0x7ec4, 0x46b3, 0xb6, 0xe4, 0x48, 0xe9, 0x26, 0xb1, 0xed, 0xa4);
        // 10a59fc7-b628-4c41-9eb8-cf37d55103cf
        public static Guid FWPM_LAYER_STREAM_V6_DISCARD = new Guid(0x10a59fc7, 0xb628, 0x4c41, 0x9e, 0xb8, 0xcf, 0x37, 0xd5, 0x51, 0x03, 0xcf);
        // 3d08bf4e-45f6-4930-a922-417098e20027
        public static Guid FWPM_LAYER_DATAGRAM_DATA_V4 = new Guid(0x3d08bf4e, 0x45f6, 0x4930, 0xa9, 0x22, 0x41, 0x70, 0x98, 0xe2, 0x00, 0x27);
        // 18e330c6-7248-4e52-aaab-472ed67704fd
        public static Guid FWPM_LAYER_DATAGRAM_DATA_V4_DISCARD = new Guid(0x18e330c6, 0x7248, 0x4e52, 0xaa, 0xab, 0x47, 0x2e, 0xd6, 0x77, 0x04, 0xfd);
        // fa45fe2f-3cba-4427-87fc-57b9a4b10d00
        public static Guid FWPM_LAYER_DATAGRAM_DATA_V6 = new Guid(0xfa45fe2f, 0x3cba, 0x4427, 0x87, 0xfc, 0x57, 0xb9, 0xa4, 0xb1, 0x0d, 0x00);
        // 09d1dfe1-9b86-4a42-be9d-8c315b92a5d0
        public static Guid FWPM_LAYER_DATAGRAM_DATA_V6_DISCARD = new Guid(0x09d1dfe1, 0x9b86, 0x4a42, 0xbe, 0x9d, 0x8c, 0x31, 0x5b, 0x92, 0xa5, 0xd0);
        // 61499990-3cb6-4e84-b950-53b94b6964f3
        public static Guid FWPM_LAYER_INBOUND_ICMP_ERROR_V4 = new Guid(0x61499990, 0x3cb6, 0x4e84, 0xb9, 0x50, 0x53, 0xb9, 0x4b, 0x69, 0x64, 0xf3);
        // a6b17075-ebaf-4053-a4e7-213c8121ede5
        public static Guid FWPM_LAYER_INBOUND_ICMP_ERROR_V4_DISCARD = new Guid(0xa6b17075, 0xebaf, 0x4053, 0xa4, 0xe7, 0x21, 0x3c, 0x81, 0x21, 0xed, 0xe5);
        // 65f9bdff-3b2d-4e5d-b8c6-c720651fe898
        public static Guid FWPM_LAYER_INBOUND_ICMP_ERROR_V6 = new Guid(0x65f9bdff, 0x3b2d, 0x4e5d, 0xb8, 0xc6, 0xc7, 0x20, 0x65, 0x1f, 0xe8, 0x98);
        // a6e7ccc0-08fb-468d-a472-9771d5595e09
        public static Guid FWPM_LAYER_INBOUND_ICMP_ERROR_V6_DISCARD = new Guid(0xa6e7ccc0, 0x08fb, 0x468d, 0xa4, 0x72, 0x97, 0x71, 0xd5, 0x59, 0x5e, 0x09);
        // 41390100-564c-4b32-bc1d-718048354d7c
        public static Guid FWPM_LAYER_OUTBOUND_ICMP_ERROR_V4 = new Guid(0x41390100, 0x564c, 0x4b32, 0xbc, 0x1d, 0x71, 0x80, 0x48, 0x35, 0x4d, 0x7c);
        // b3598d36-0561-4588-a6bf-e955e3f6264b
        public static Guid FWPM_LAYER_OUTBOUND_ICMP_ERROR_V4_DISCARD = new Guid(0xb3598d36, 0x0561, 0x4588, 0xa6, 0xbf, 0xe9, 0x55, 0xe3, 0xf6, 0x26, 0x4b);
        // 7fb03b60-7b8d-4dfa-badd-980176fc4e12
        public static Guid FWPM_LAYER_OUTBOUND_ICMP_ERROR_V6 = new Guid(0x7fb03b60, 0x7b8d, 0x4dfa, 0xba, 0xdd, 0x98, 0x01, 0x76, 0xfc, 0x4e, 0x12);
        // 65f2e647-8d0c-4f47-b19b-33a4d3f1357c
        public static Guid FWPM_LAYER_OUTBOUND_ICMP_ERROR_V6_DISCARD = new Guid(0x65f2e647, 0x8d0c, 0x4f47, 0xb1, 0x9b, 0x33, 0xa4, 0xd3, 0xf1, 0x35, 0x7c);
        // 1247d66d-0b60-4a15-8d44-7155d0f53a0c
        public static Guid FWPM_LAYER_ALE_RESOURCE_ASSIGNMENT_V4 = new Guid(0x1247d66d, 0x0b60, 0x4a15, 0x8d, 0x44, 0x71, 0x55, 0xd0, 0xf5, 0x3a, 0x0c);
        // 0b5812a2-c3ff-4eca-b88d-c79e20ac6322
        public static Guid FWPM_LAYER_ALE_RESOURCE_ASSIGNMENT_V4_DISCARD = new Guid(0x0b5812a2, 0xc3ff, 0x4eca, 0xb8, 0x8d, 0xc7, 0x9e, 0x20, 0xac, 0x63, 0x22);
        // 55a650e1-5f0a-4eca-a653-88f53b26aa8c
        public static Guid FWPM_LAYER_ALE_RESOURCE_ASSIGNMENT_V6 = new Guid(0x55a650e1, 0x5f0a, 0x4eca, 0xa6, 0x53, 0x88, 0xf5, 0x3b, 0x26, 0xaa, 0x8c);
        // cbc998bb-c51f-4c1a-bb4f-9775fcacab2f
        public static Guid FWPM_LAYER_ALE_RESOURCE_ASSIGNMENT_V6_DISCARD = new Guid(0xcbc998bb, 0xc51f, 0x4c1a, 0xbb, 0x4f, 0x97, 0x75, 0xfc, 0xac, 0xab, 0x2f);
        // 88bb5dad-76d7-4227-9c71-df0a3ed7be7e
        public static Guid FWPM_LAYER_ALE_AUTH_LISTEN_V4 = new Guid(0x88bb5dad, 0x76d7, 0x4227, 0x9c, 0x71, 0xdf, 0x0a, 0x3e, 0xd7, 0xbe, 0x7e);
        // 371dfada-9f26-45fd-b4eb-c29eb212893f
        public static Guid FWPM_LAYER_ALE_AUTH_LISTEN_V4_DISCARD = new Guid(0x371dfada, 0x9f26, 0x45fd, 0xb4, 0xeb, 0xc2, 0x9e, 0xb2, 0x12, 0x89, 0x3f);
        // 7ac9de24-17dd-4814-b4bd-a9fbc95a321b
        public static Guid FWPM_LAYER_ALE_AUTH_LISTEN_V6 = new Guid(0x7ac9de24, 0x17dd, 0x4814, 0xb4, 0xbd, 0xa9, 0xfb, 0xc9, 0x5a, 0x32, 0x1b);
        // 60703b07-63c8-48e9-ada3-12b1af40a617
        public static Guid FWPM_LAYER_ALE_AUTH_LISTEN_V6_DISCARD = new Guid(0x60703b07, 0x63c8, 0x48e9, 0xad, 0xa3, 0x12, 0xb1, 0xaf, 0x40, 0xa6, 0x17);
        // e1cd9fe7-f4b5-4273-96c0-592e487b8650
        public static Guid FWPM_LAYER_ALE_AUTH_RECV_ACCEPT_V4 = new Guid(0xe1cd9fe7, 0xf4b5, 0x4273, 0x96, 0xc0, 0x59, 0x2e, 0x48, 0x7b, 0x86, 0x50);
        // 9eeaa99b-bd22-4227-919f-0073c63357b1
        public static Guid FWPM_LAYER_ALE_AUTH_RECV_ACCEPT_V4_DISCARD = new Guid(0x9eeaa99b, 0xbd22, 0x4227, 0x91, 0x9f, 0x00, 0x73, 0xc6, 0x33, 0x57, 0xb1);
        // a3b42c97-9f04-4672-b87e-cee9c483257f
        public static Guid FWPM_LAYER_ALE_AUTH_RECV_ACCEPT_V6 = new Guid(0xa3b42c97, 0x9f04, 0x4672, 0xb8, 0x7e, 0xce, 0xe9, 0xc4, 0x83, 0x25, 0x7f);
        // 89455b97-dbe1-453f-a224-13da895af396
        public static Guid FWPM_LAYER_ALE_AUTH_RECV_ACCEPT_V6_DISCARD = new Guid(0x89455b97, 0xdbe1, 0x453f, 0xa2, 0x24, 0x13, 0xda, 0x89, 0x5a, 0xf3, 0x96);
        // c38d57d1-05a7-4c33-904f-7fbceee60e82
        public static Guid FWPM_LAYER_ALE_AUTH_CONNECT_V4 = new Guid(0xc38d57d1, 0x05a7, 0x4c33, 0x90, 0x4f, 0x7f, 0xbc, 0xee, 0xe6, 0x0e, 0x82);
        // d632a801-f5ba-4ad6-96e3-607017d9836a
        public static Guid FWPM_LAYER_ALE_AUTH_CONNECT_V4_DISCARD = new Guid(0xd632a801, 0xf5ba, 0x4ad6, 0x96, 0xe3, 0x60, 0x70, 0x17, 0xd9, 0x83, 0x6a);
        // 4a72393b-319f-44bc-84c3-ba54dcb3b6b4
        public static Guid FWPM_LAYER_ALE_AUTH_CONNECT_V6 = new Guid(0x4a72393b, 0x319f, 0x44bc, 0x84, 0xc3, 0xba, 0x54, 0xdc, 0xb3, 0xb6, 0xb4);
        // c97bc3b8-c9a3-4e33-8695-8e17aad4de09
        public static Guid FWPM_LAYER_ALE_AUTH_CONNECT_V6_DISCARD = new Guid(0xc97bc3b8, 0xc9a3, 0x4e33, 0x86, 0x95, 0x8e, 0x17, 0xaa, 0xd4, 0xde, 0x09);
        // af80470a-5596-4c13-9992-539e6fe57967
        public static Guid FWPM_LAYER_ALE_FLOW_ESTABLISHED_V4 = new Guid(0xaf80470a, 0x5596, 0x4c13, 0x99, 0x92, 0x53, 0x9e, 0x6f, 0xe5, 0x79, 0x67);
        // 146ae4a9-a1d2-4d43-a31a-4c42682b8e4f
        public static Guid FWPM_LAYER_ALE_FLOW_ESTABLISHED_V4_DISCARD = new Guid(0x146ae4a9, 0xa1d2, 0x4d43, 0xa3, 0x1a, 0x4c, 0x42, 0x68, 0x2b, 0x8e, 0x4f);
        // 7021d2b3-dfa4-406e-afeb-6afaf7e70efd
        public static Guid FWPM_LAYER_ALE_FLOW_ESTABLISHED_V6 = new Guid(0x7021d2b3, 0xdfa4, 0x406e, 0xaf, 0xeb, 0x6a, 0xfa, 0xf7, 0xe7, 0x0e, 0xfd);
        // 46928636-bbca-4b76-941d-0fa7f5d7d372
        public static Guid FWPM_LAYER_ALE_FLOW_ESTABLISHED_V6_DISCARD = new Guid(0x46928636, 0xbbca, 0x4b76, 0x94, 0x1d, 0x0f, 0xa7, 0xf5, 0xd7, 0xd3, 0x72);
        // effb7edb-0055-4f9a-a231-4ff8131ad191
        public static Guid FWPM_LAYER_INBOUND_MAC_FRAME_ETHERNET = new Guid(0xeffb7edb, 0x0055, 0x4f9a, 0xa2, 0x31, 0x4f, 0xf8, 0x13, 0x1a, 0xd1, 0x91);
        // 694673bc-d6db-4870-adee-0acdbdb7f4b2
        public static Guid FWPM_LAYER_OUTBOUND_MAC_FRAME_ETHERNET = new Guid(0x694673bc, 0xd6db, 0x4870, 0xad, 0xee, 0x0a, 0xcd, 0xbd, 0xb7, 0xf4, 0xb2);
        // d4220bd3-62ce-4f08-ae88-b56e8526df50
        public static Guid FWPM_LAYER_INBOUND_MAC_FRAME_NATIVE = new Guid(0xd4220bd3, 0x62ce, 0x4f08, 0xae, 0x88, 0xb5, 0x6e, 0x85, 0x26, 0xdf, 0x50);
        // 94c44912-9d6f-4ebf-b995-05ab8a088d1b
        public static Guid FWPM_LAYER_OUTBOUND_MAC_FRAME_NATIVE = new Guid(0x94c44912, 0x9d6f, 0x4ebf, 0xb9, 0x95, 0x05, 0xab, 0x8a, 0x08, 0x8d, 0x1b);
        // 7d98577a-9a87-41ec-9718-7cf589c9f32d
        public static Guid FWPM_LAYER_INGRESS_VSWITCH_ETHERNET = new Guid(0x7d98577a, 0x9a87, 0x41ec, 0x97, 0x18, 0x7c, 0xf5, 0x89, 0xc9, 0xf3, 0x2d);
        // 86c872b0-76fa-4b79-93a4-0750530ae292
        public static Guid FWPM_LAYER_EGRESS_VSWITCH_ETHERNET = new Guid(0x86c872b0, 0x76fa, 0x4b79, 0x93, 0xa4, 0x07, 0x50, 0x53, 0x0a, 0xe2, 0x92);
        // b2696ff6-774f-4554-9f7d-3da3945f8e85
        public static Guid FWPM_LAYER_INGRESS_VSWITCH_TRANSPORT_V4 = new Guid(0xb2696ff6, 0x774f, 0x4554, 0x9f, 0x7d, 0x3d, 0xa3, 0x94, 0x5f, 0x8e, 0x85);
        // 5ee314fc-7d8a-47f4-b7e3-291a36da4e12
        public static Guid FWPM_LAYER_INGRESS_VSWITCH_TRANSPORT_V6 = new Guid(0x5ee314fc, 0x7d8a, 0x47f4, 0xb7, 0xe3, 0x29, 0x1a, 0x36, 0xda, 0x4e, 0x12);
        // b92350b6-91f0-46b6-bdc4-871dfd4a7c98
        public static Guid FWPM_LAYER_EGRESS_VSWITCH_TRANSPORT_V4 = new Guid(0xb92350b6, 0x91f0, 0x46b6, 0xbd, 0xc4, 0x87, 0x1d, 0xfd, 0x4a, 0x7c, 0x98);
        // 1b2def23-1881-40bd-82f4-4254e63141cb
        public static Guid FWPM_LAYER_EGRESS_VSWITCH_TRANSPORT_V6 = new Guid(0x1b2def23, 0x1881, 0x40bd, 0x82, 0xf4, 0x42, 0x54, 0xe6, 0x31, 0x41, 0xcb);
        // e41d2719-05c7-40f0-8983-ea8d17bbc2f6
        public static Guid FWPM_LAYER_INBOUND_TRANSPORT_FAST = new Guid(0xe41d2719, 0x05c7, 0x40f0, 0x89, 0x83, 0xea, 0x8d, 0x17, 0xbb, 0xc2, 0xf6);
        // 13ed4388-a070-4815-9935-7a9be6408b78
        public static Guid FWPM_LAYER_OUTBOUND_TRANSPORT_FAST = new Guid(0x13ed4388, 0xa070, 0x4815, 0x99, 0x35, 0x7a, 0x9b, 0xe6, 0x40, 0x8b, 0x78);
        // 853aaa8e-2b78-4d24-a804-36db08b29711
        public static Guid FWPM_LAYER_INBOUND_MAC_FRAME_NATIVE_FAST = new Guid(0x853aaa8e, 0x2b78, 0x4d24, 0xa8, 0x04, 0x36, 0xdb, 0x08, 0xb2, 0x97, 0x11);
        // 470df946-c962-486f-9446-8293cbc75eb8
        public static Guid FWPM_LAYER_OUTBOUND_MAC_FRAME_NATIVE_FAST = new Guid(0x470df946, 0xc962, 0x486f, 0x94, 0x46, 0x82, 0x93, 0xcb, 0xc7, 0x5e, 0xb8);
        // f02b1526-a459-4a51-b9e3-759de52b9d2c
        public static Guid FWPM_LAYER_IPSEC_KM_DEMUX_V4 = new Guid(0xf02b1526, 0xa459, 0x4a51, 0xb9, 0xe3, 0x75, 0x9d, 0xe5, 0x2b, 0x9d, 0x2c);
        // 2f755cf6-2fd4-4e88-b3e4-a91bca495235
        public static Guid FWPM_LAYER_IPSEC_KM_DEMUX_V6 = new Guid(0x2f755cf6, 0x2fd4, 0x4e88, 0xb3, 0xe4, 0xa9, 0x1b, 0xca, 0x49, 0x52, 0x35);
        // eda65c74-610d-4bc5-948f-3c4f89556867
        public static Guid FWPM_LAYER_IPSEC_V4 = new Guid(0xeda65c74, 0x610d, 0x4bc5, 0x94, 0x8f, 0x3c, 0x4f, 0x89, 0x55, 0x68, 0x67);
        // 13c48442-8d87-4261-9a29-59d2abc348b4
        public static Guid FWPM_LAYER_IPSEC_V6 = new Guid(0x13c48442, 0x8d87, 0x4261, 0x9a, 0x29, 0x59, 0xd2, 0xab, 0xc3, 0x48, 0xb4);
        // b14b7bdb-dbbd-473e-bed4-8b4708d4f270
        public static Guid FWPM_LAYER_IKEEXT_V4 = new Guid(0xb14b7bdb, 0xdbbd, 0x473e, 0xbe, 0xd4, 0x8b, 0x47, 0x08, 0xd4, 0xf2, 0x70);
        // b64786b3-f687-4eb9-89d2-8ef32acdabe2
        public static Guid FWPM_LAYER_IKEEXT_V6 = new Guid(0xb64786b3, 0xf687, 0x4eb9, 0x89, 0xd2, 0x8e, 0xf3, 0x2a, 0xcd, 0xab, 0xe2);
        // 75a89dda-95e4-40f3-adc7-7688a9c847e1
        public static Guid FWPM_LAYER_RPC_UM = new Guid(0x75a89dda, 0x95e4, 0x40f3, 0xad, 0xc7, 0x76, 0x88, 0xa9, 0xc8, 0x47, 0xe1);
        // 9247bc61-eb07-47ee-872c-bfd78bfd1616
        public static Guid FWPM_LAYER_RPC_EPMAP = new Guid(0x9247bc61, 0xeb07, 0x47ee, 0x87, 0x2c, 0xbf, 0xd7, 0x8b, 0xfd, 0x16, 0x16);
        // 618dffc7-c450-4943-95db-99b4c16a55d4
        public static Guid FWPM_LAYER_RPC_EP_ADD = new Guid(0x618dffc7, 0xc450, 0x4943, 0x95, 0xdb, 0x99, 0xb4, 0xc1, 0x6a, 0x55, 0xd4);
        // 94a4b50b-ba5c-4f27-907a-229fac0c2a7a
        public static Guid FWPM_LAYER_RPC_PROXY_CONN = new Guid(0x94a4b50b, 0xba5c, 0x4f27, 0x90, 0x7a, 0x22, 0x9f, 0xac, 0x0c, 0x2a, 0x7a);
        // f8a38615-e12c-41ac-98df-121ad981aade
        public static Guid FWPM_LAYER_RPC_PROXY_IF = new Guid(0xf8a38615, 0xe12c, 0x41ac, 0x98, 0xdf, 0x12, 0x1a, 0xd9, 0x81, 0xaa, 0xde);
        // 4aa226e9-9020-45fb-956a-c0249d841195
        public static Guid FWPM_LAYER_KM_AUTHORIZATION = new Guid(0x4aa226e9, 0x9020, 0x45fb, 0x95, 0x6a, 0xc0, 0x24, 0x9d, 0x84, 0x11, 0x95);
        // 0c2aa681-905b-4ccd-a467-4dd811d07b7b
        public static Guid FWPM_LAYER_NAME_RESOLUTION_CACHE_V4 = new Guid(0x0c2aa681, 0x905b, 0x4ccd, 0xa4, 0x67, 0x4d, 0xd8, 0x11, 0xd0, 0x7b, 0x7b);
        // 92d592fa-6b01-434a-9dea-d1e96ea97da9
        public static Guid FWPM_LAYER_NAME_RESOLUTION_CACHE_V6 = new Guid(0x92d592fa, 0x6b01, 0x434a, 0x9d, 0xea, 0xd1, 0xe9, 0x6e, 0xa9, 0x7d, 0xa9);
        // 74365cce-ccb0-401a-bfc1-b89934ad7e15
        public static Guid FWPM_LAYER_ALE_RESOURCE_RELEASE_V4 = new Guid(0x74365cce, 0xccb0, 0x401a, 0xbf, 0xc1, 0xb8, 0x99, 0x34, 0xad, 0x7e, 0x15);
        // f4e5ce80-edcc-4e13-8a2f-b91454bb057b
        public static Guid FWPM_LAYER_ALE_RESOURCE_RELEASE_V6 = new Guid(0xf4e5ce80, 0xedcc, 0x4e13, 0x8a, 0x2f, 0xb9, 0x14, 0x54, 0xbb, 0x05, 0x7b);
        // b4766427-e2a2-467a-bd7e-dbcd1bd85a09
        public static Guid FWPM_LAYER_ALE_ENDPOINT_CLOSURE_V4 = new Guid(0xb4766427, 0xe2a2, 0x467a, 0xbd, 0x7e, 0xdb, 0xcd, 0x1b, 0xd8, 0x5a, 0x09);
        // bb536ccd-4755-4ba9-9ff7-f9edf8699c7b
        public static Guid FWPM_LAYER_ALE_ENDPOINT_CLOSURE_V6 = new Guid(0xbb536ccd, 0x4755, 0x4ba9, 0x9f, 0xf7, 0xf9, 0xed, 0xf8, 0x69, 0x9c, 0x7b);
        // c6e63c8c-b784-4562-aa7d-0a67cfcaf9a3
        public static Guid FWPM_LAYER_ALE_CONNECT_REDIRECT_V4 = new Guid(0xc6e63c8c, 0xb784, 0x4562, 0xaa, 0x7d, 0x0a, 0x67, 0xcf, 0xca, 0xf9, 0xa3);
        // 587e54a7-8046-42ba-a0aa-b716250fc7fd
        public static Guid FWPM_LAYER_ALE_CONNECT_REDIRECT_V6 = new Guid(0x587e54a7, 0x8046, 0x42ba, 0xa0, 0xaa, 0xb7, 0x16, 0x25, 0x0f, 0xc7, 0xfd);
        // 66978cad-c704-42ac-86ac-7c1a231bd253
        public static Guid FWPM_LAYER_ALE_BIND_REDIRECT_V4 = new Guid(0x66978cad, 0xc704, 0x42ac, 0x86, 0xac, 0x7c, 0x1a, 0x23, 0x1b, 0xd2, 0x53);
        // bef02c9c-606b-4536-8c26-1c2fc7b631d4
        public static Guid FWPM_LAYER_ALE_BIND_REDIRECT_V6 = new Guid(0xbef02c9c, 0x606b, 0x4536, 0x8c, 0x26, 0x1c, 0x2f, 0xc7, 0xb6, 0x31, 0xd4);
        // af52d8ec-cb2d-44e5-ad92-f8dc38d2eb29
        public static Guid FWPM_LAYER_STREAM_PACKET_V4 = new Guid(0xaf52d8ec, 0xcb2d, 0x44e5, 0xad, 0x92, 0xf8, 0xdc, 0x38, 0xd2, 0xeb, 0x29);
        // 779a8ca3-f099-468f-b5d4-83535c461c02
        public static Guid FWPM_LAYER_STREAM_PACKET_V6 = new Guid(0x779a8ca3, 0xf099, 0x468f, 0xb5, 0xd4, 0x83, 0x53, 0x5c, 0x46, 0x1c, 0x02);
        // f4fb8d55-c076-46d8-a2c7-6a4c722ca4ed
        public static Guid FWPM_LAYER_INBOUND_RESERVED2 = new Guid(0xf4fb8d55, 0xc076, 0x46d8, 0xa2, 0xc7, 0x6a, 0x4c, 0x72, 0x2c, 0xa4, 0xed);
    }
}