# Fable 4 + Feliz + Elmish + RemoteDev + Vite

This is an example on how to use Fable 4 + Feliz + Elmish + RemoteDev + Vite.

Click the button below to start a new development environment:

[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/MangelMaxime/template-gitpod-fable-3)

## Notes

You need to install RemoteDev Tool extension.

Everything is working as a normal project, we just had to add:

```html
    <script type="text/javascript">
        window.global = window;
    </script>
```

to the `index.html` file in order to workaround a limitation on `socketcluster-client` / `remotedev`.
