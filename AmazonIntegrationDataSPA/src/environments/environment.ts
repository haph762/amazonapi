const protocol: string = window.location.protocol;
const hostname: string = window.location.hostname;
const port: string = ':5000';
const ip: string = `${ hostname }${ port }`;
const baseUrl: string = `${ protocol }//${ ip }`;

export const environment = {
  production: false,
  api: `${ baseUrl }/api/`,
  baseUrl: `${ baseUrl }/`,
}
