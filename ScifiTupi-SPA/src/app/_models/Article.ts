export interface Article {
    id: number;
    title: string;
    alias: string;
    introText: string;
    category: string;
    CreatedDt: Date;
    createdByAlias: string;
    imageIcon: string;
    hits: number;
}
